using System;
using System.Windows.Forms;

namespace CasparCG_Now_Playing
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

            string monitorIp        = System.Configuration.ConfigurationManager.AppSettings.Get("monitorIp");
            string monitorPort      = System.Configuration.ConfigurationManager.AppSettings.Get("monitorPort");
            string monitorChannel   = System.Configuration.ConfigurationManager.AppSettings.Get("monitorChannel");
            string monitorLayer     = System.Configuration.ConfigurationManager.AppSettings.Get("monitorLayer");
            labelListenIpPort.Text  = "Monitor " + monitorIp + ":" + monitorPort;
            labelChannel.Text       = monitorChannel;
            labelLayer.Text         = monitorLayer;
        }

        private void windowForm_Load(object sender, EventArgs e)
        {
        }

        private void labelCuriousjamesnet_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        public void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            labelCuriousjamesnet.LinkVisited = true;
            labelCuriousjamesnet.Text = "thingy";
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("http://curiousjames.net");
        }
    }
}