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

        static void vlanConfiguration(string PPPusername, string PPPpassword)
        {

            string _PPPusername = PPPusername;
            string _PPPpassword = PPPpassword;
            var modem = new Browser();

            var modemURL = "http://192.168.20.1/qinetsetup.html";
            modem.Navigate(modemURL);
            //    Console.Write("get url");
            //    modem.BasicAuthenticationLogin("Broadband Router","admin","admin");
            modem.BasicAuthenticationLogin("192.168.20.1", "admin", "admin");


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

        }
    }
}
