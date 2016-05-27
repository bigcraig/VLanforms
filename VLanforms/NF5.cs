using SimpleBrowser;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VLanforms
{
    public partial class NF5 : Form
    {
        //  This class will contain code to configure the NF5
        //     login -> configure networkVlan100  c-> configure TR0-069
        //
        string PPPusername, PPPpassword;

        static string getAMSessionCookie(string html)
        {      // static since we dont need to instance another program class to run it

            string _pattern = @"var AMSESSIONID='([^']+)';";
            Match match = Regex.Match(html, _pattern);
            return match.Groups[1].Value;

        }

        void nf5Configuration(string PPPusername, string PPPpassword)
        {
            configureModem.Text = "Configuring Vlan";
            string _PPPusername = PPPusername;
            string _PPPpassword = PPPpassword;
            var modem = new Browser();
            Browser.RefererModes ModemBrowserMode;
            
            ModemBrowserMode = Browser.RefererModes.OriginWhenCrossOrigin;
          


            modem.RefererMode = ModemBrowserMode;
            var modemURL = "http://192.168.20.1/";
            var loginString = "log/in?un=admin&pw=admin&rd=%2Fuir%2Find.htm&rd2=%2Fuir%2Fbsc_login.htm&Nrd=1 ";
            int timeOut = 3000;
            modemURL = modemURL + loginString;
            modem.Navigate(modemURL, timeOut);

            if (modem.RequestData().ResponseCode != 200)
            {
                ;
                configureModem.Text = "modem is not online, please connect,wait and click again";
                return;
            }

          
            var  modemIP = "http://192.168.20.1/";
            var pppoE100Vlan = "prim.htm?_scb=0&Nrb=1&S00900300=&S00900302=&_ccb=0&I00010005=255.255.255.0&N00900004=0&N00900000=1&N80900010=1&N00010023=1&Nwanif=0&Nwanif2=0&Nwanif3=99&Nwanif4=0&N00010083=1&N00410101=0&_ccb=0&N00010003=0x40&_ccb=0&N001E000D=&I00110001=&I00110002=&I00110003=&I00110004=&I00110005=&N0011000F=0&S00035002=&_sce=%25Nsc0&B0001000F=&_sce=%25Nsc1&N0003500E=1&N0003500F=0&Ssession=x&N00042000=1&N00042100=1&S00040100=craig%40bigpond.com&S00040200=loser69&I00040700=&I00040800=&N00040912=1&N00040B00=600&S00040600=&I00040300=&N00040A00=0&N0004000F=0&N00050E00=0&I00050300=&I00050400=&I00050500=&S00050600=&S00050100=&S00050200=&S00050F00=&N00050B00=600&N00050911=1&N00050A00=0&N00054100=0&N00060E00=0&I00060300=&I00060400=&I00060500=&S00060600=&S00060100=&S00060200=&N00060B00=600&N00060002=1&N00060A00=0&N00064300=0&_ccb=0&N00410104=0&N00410102=8&N00410103=35&N00410105=0&_cce=0x80410001&N001E0016=1&N00201100=3&N00201101=0&N00201102=0&S001E0003=&S001E0004=&S001E0005=&S001E0001=&S001E0002=&N001E000F=0&I001E0008=&I001E0009=&N001E0032=1&acrt=0&N001E0040=0&N001E000B=0&N001E0010=0&S00340100=&S00340200=&I00340700=&I00340800=&N00340001=0&N00340B00=600&S00340600=&I00340300=&N00340A00=0&N0034000F=0&N0015000E=1&N00010210=&N0015000C=&N00010199=&N0015003A=0&N009320C1=1&N00932001=100&N00933010=0&N80010009=1&N80010081=1&_sce=%25Ssc";

                modemURL = modemIP + pppoE100Vlan;
                modem.Navigate(modemURL, timeOut);
               

            string tr069Configuration = "tr069.htm?N00300001=1&S00300005=http%3A%2F%2Facs.netcommwireless.com%2Fcpe.php&S00300006=cpe&S00300007=cpe&N00300011=8099&S00300012=cpe&S00300013=cpe&N00300020=1&N00300021=86399&_cce=0x80300001&N80150002=1&_sce=%25Ssc";

            modemURL = modemIP + tr069Configuration;
            modem.Navigate(modemURL, timeOut);
        }


        public NF5()
        {
            InitializeComponent();
        }
        ~NF5() { }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NF5_Load(object sender, EventArgs e)
        {

        }

        private void usernameControl_TextChanged(object sender, EventArgs e)
        {
            PPPusername = usernameControl.Text;
            configureModem.Text = "Click to Configure Modem";
        }

        private void passwordControl_TextChanged(object sender, EventArgs e)
        {
            PPPpassword = passwordControl.Text;
            configureModem.Text = "Click to Configure Modem";
        }

        private void configureModem_Click(object sender, EventArgs e)
        {
            nf5Configuration(PPPusername, PPPpassword);


        }
    }
}
