using System;
using System.Windows.Forms;
// Below namepaces are required for OSC operation
using System.Net;
using Bespoke.Common.Osc;

namespace CasparCG_Now_Playing
{
    public partial class formMain : Form
    {
        public static int monitorPort
        {
            get { return int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("monitorPort")); }
        }
        public static int monitorChannel
        {
            get { return int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("monitorChannel")); }
        }
        public static int monitorLayer
        {
            get { return int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("monitorLayer")); }
        }
        public static bool oscAutoStart
        {
            get { return bool.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("oscAutoStart")); }
        }

        string layerPathRoot = "/channel/" + monitorChannel.ToString() + "/stage/layer/" + monitorLayer + "/";

        private OscServer casparCgOscServer = new OscServer(TransportType.Udp, IPAddress.Any, monitorPort);

        //string layerFilePath;
        float layerFps;

        public formMain()
        {
            InitializeComponent();

            labelListenIpPort.Text = "Monitor Port: " + monitorPort.ToString();
            labelChannel.Text = "Channel: " + monitorChannel.ToString();
            labelLayer.Text = "Layer: " + monitorLayer.ToString();

            casparCgOscServer.MessageReceived += casparCgOscServer_MessageReceived;
            casparCgOscServer.BundleReceived += casparCgOscServer_BundleReceived;

            if (oscAutoStart==true)
            {
                oscStart();
            }
        }

        void casparCgOscServer_BundleReceived(object sender, OscBundleReceivedEventArgs e)
        {
            foreach (OscMessage m in e.Bundle.Messages)
            {
                filterOscMessage(m);
            }
        }

        void casparCgOscServer_MessageReceived(object sender, OscMessageReceivedEventArgs e)
        {
            filterOscMessage(e.Message);
        }

        private void filterOscMessage(OscMessage m)
        {
            string d1 = m.Data[0].ToString();
            string d2 = (m.Data.Count > 1) ? m.Data[1].ToString() : null;
            string d3 = (m.Data.Count > 2) ? m.Data[2].ToString() : null;

            string addressFull = m.Address.ToString();
            string[] addressSplit = addressFull.Split('/'); 

            if (addressFull == layerPathRoot + "file/fps")
            {
                updateFps(d1);
            }
            if (addressFull == layerPathRoot + "file/frame")
            {
                updateFramesPlayedRemaining(d1, d2);
            }
            if (addressFull == layerPathRoot + "loop")
            {
                updateLoop(d1);
            }
            if (addressFull == layerPathRoot + "file/path")
            {
                updateFilePath(d1);
            }

            labelLastMsgValue.Invoke(new MethodInvoker(() => {
                labelLastMsgValue.Text = m.Address.ToString();
            }));
        }

        private string calculateTimeDisplay(int totalFrames)
        {
            //Calculate hh:mm:ss:ff from frames and fps
            float frames = totalFrames % layerFps;
            float framesLeftToDisplay = totalFrames / layerFps;

            //Covert the remaining seconds to hh:mm:ss
            TimeSpan time = TimeSpan.FromSeconds(framesLeftToDisplay);
            string displayTime = time.ToString(@"hh\:mm\:ss\:") + frames.ToString("00");

            return displayTime;
        }

        private void updateFilePath(string v)
        {
            labelFilePathValue.Invoke(new MethodInvoker(() =>
            {
                labelFilePathValue.Text = v;
            }));
        }

        private void updateFps(string data)
        {
            layerFps = float.Parse(data);

            labelFpsValue.Invoke(new MethodInvoker(() =>
            {
                labelFpsValue.Text = layerFps.ToString();
            }));
        }

        private void updateFramesPlayedRemaining(string framesPlayedStr, string framesTotalStr)
        {
            int framesPlayed = int.Parse(framesPlayedStr);
            int framesRemaining = int.Parse(framesTotalStr) - framesPlayed;

            string timePlayedDisplay = calculateTimeDisplay(framesPlayed);
            string timeRemainingDisplay = calculateTimeDisplay(framesRemaining);

            labelFramesPlayedValue.Invoke(new MethodInvoker(() =>
            {
                labelFramesPlayedValue.Text = framesPlayed.ToString();
            }));

            labelTimePlayedValue.Invoke(new MethodInvoker(() =>
            {
                labelTimePlayedValue.Text = timePlayedDisplay;
            }));

            labelFramesRemainingValue.Invoke(new MethodInvoker(() =>
            {
                labelFramesRemainingValue.Text = framesRemaining.ToString();
            }));

            labelFramesRemainingValue.Invoke(new MethodInvoker(() =>
            {
                labelTimeRemainingValue.Text = timeRemainingDisplay;
            }));
        }

        private void updateLoop(string v)
        {
            labelLoopValue.Invoke(new MethodInvoker(() =>
            {
                labelLoopValue.Text = v.ToString();
            }));
        }

        private void updatePaused(string v)
        {
            labelPausedValue.Invoke(new MethodInvoker(() =>
            {
                labelPausedValue.Text = v.ToString();
            }));
        }

        private void buttonOscStartStop_Click(object sender, EventArgs e)
        {
            if (casparCgOscServer.IsRunning) //Stop OSC Listener
            {
                oscStop();
            }
            else //Start OSC Listener
            {
                oscStart();
            }
        }

        private void oscStart()
        {
            buttonOscStartStop.Text = "Stop OSC";
            casparCgOscServer.Start();
        }

        private void oscStop()
        {
            buttonOscStartStop.Text = "Start OSC";
            casparCgOscServer.Stop();
        }

        private void labelCuriousjamesnet_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                visitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        public void visitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            labelCuriousjamesnet.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("http://curiousjames.net");
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            updateFilePath("");
            updateFps("1");
            updateFramesPlayedRemaining("0","0");
            updateLoop("False");
            updatePaused("False");
        }
    }
}