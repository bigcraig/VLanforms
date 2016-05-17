using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleBrowser;
using System.Text.RegularExpressions;

namespace VLanforms
{
    public partial class Form1 : Form
    {
        string PPPusername, PPPpassword;

        public Form1()
        {
            InitializeComponent();
        }

       static string getSessionID(string html)
        {      // static since we dont need to instance another program class to run it

            string _pattern = @"var sessionKey='([^']+)';";
            Match match = Regex.Match(html, _pattern);
            return match.Groups[1].Value;

        }

        static string ACSConfigString(string sessionKey)
        /* string Tr69cAcsPwd,
         string tr69cConnReqUser,
         string tr69cConnReqPwd,
         string tr69cConnReqPort,
         string tr69cAcsUrl,
         string informInterval) */
        {
            string _acspost;
            _acspost = "tr69cfg.cgi?tr69cEnable=1&tr69cInformEnable=1&tr69cInformInterval=86423&tr69cAcsURL=http://acs.netcommwireless.com/cpe.php&tr69cAcsUser=cpe&tr69cAcsPwd=cpe&tr69cConnReqUser=cpe&tr69cConnReqPwd=cpe&tr69cConnReqPort=30005&tr69cNoneConnReqAuth=0&tr69cDebugEnable=0&tr69cBoundIfName=Any_WAN&sessionKey=";
            _acspost = _acspost + sessionKey;
            // Console.Write(_acspost);
            return (_acspost);
        }

        void vlanConfiguration(string PPPusername, string PPPpassword)
        {
            configureModem.Text = "Configring Vlan";
            string _PPPusername= PPPusername;
            string _PPPpassword = PPPpassword;
            var modem = new Browser();
            Browser.RefererModes ModemBrowserMode;
            // add referrer for NF4V"
            ModemBrowserMode = Browser.RefererModes.OriginWhenCrossOrigin;
            // add referrer for NF4V"


            modem.RefererMode = ModemBrowserMode;
            var modemURL = "http://192.168.20.1/";
         
            modem.Navigate(modemURL);

            //    Console.Write("get url");
            //    modem.BasicAuthenticationLogin("Broadband Router","admin","admin");
            modem.BasicAuthenticationLogin("192.168.20.1", "admin", "admin");
        
            modemURL = "http://192.168.20.1";
         //   modem.SetHeader("Referejkjjr:http://192.168.20.1/");
            modem.Navigate(modemURL);

            modemURL = "http://192.168.20.1/qinetsetup.html";
           
           
            modem.Navigate(modemURL);
            //     Console.Write(modem.CurrentHtml);
            var html = modem.CurrentHtml;
            string sessionKey = getSessionID(html);
            // post wlan type
            modemURL = "http://192.168.20.1/qvdslwanmode.cgi?wanType=2&sessionKey=" + sessionKey;
            modem.Navigate(modemURL);
            html = modem.CurrentHtml;
            sessionKey = getSessionID(html);
            modemURL = "http://192.168.20.1/qvdslppp.cgi?ntwkPrtcl=0&enblOnDemand=0&pppTimeOut=0&enblv4=1&useStaticIpAddress=0&pppIpExtension=0&enblFirewall=1&enblNat=1&enblIgmp=1&keepalive=1&keepalivetime=5&alivemaxfail=30&enVlanMux=1&vlanMuxId=69&vlanMuxPr=0&enblPppDebug=0&maxMtu=1492&keepalive=0&enblv6=0&pppAuthErrorRetry=0&pppAuthMethod=0&sessionKey=" + sessionKey;
            modem.Navigate(modemURL);
            html = modem.CurrentHtml;
            sessionKey = getSessionID(html);
            modemURL = "http://192.168.20.1/qsetup.cmd?pppUserName="
                + _PPPusername + "&pppPassword="
                + _PPPpassword +"&portId=0&ptmPriorityNorm=1&ptmPriorityHigh=1&connMode=1&burstsize=3000&enblQos=1&grpPrec=8&grpAlg=WRR&grpWght=1&prec=8&alg=WRR&wght=1&sessionKey=" + sessionKey;
            modem.Navigate(modemURL);
            configureModem.Text = "Configuring ACS";
            configureACS(modem);

        }


        static void configureACS(Browser modem)
        {
            var modemURL = "http://192.168.20.1/tr69cfg.html";
            modem.Navigate(modemURL);
            var html = modem.CurrentHtml;
            string sessionKey = getSessionID(html);

            var getstringACS = ACSConfigString(sessionKey);
            modemURL = modemURL + getstringACS;
            modem.Navigate(modemURL);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            configureModem.Text = "Configuring Modem please wait";
            vlanConfiguration(PPPusername,PPPpassword);
            configureModem.Text = "Configured!!!!!!";
        }

        private void usernameControl_TextChanged(object sender, EventArgs e)
        {
            PPPusername = usernameControl.Text;
            configureModem.Text = "Click to Configure Modem";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordControl_TextChanged(object sender, EventArgs e)
        {
            PPPpassword = passwordControl.Text;
            configureModem.Text = "Click to Configure Modem";
        }
    }
}
