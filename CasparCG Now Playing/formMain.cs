using System;
using System.Windows.Forms;

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

        string layerFilePath = null;
        int layerFps = 25;
        int layerFramesPlayed = 314159;
        int layerFramesRemaining = 45;
        bool layerLoop = false;
        bool layerPaused = false;

        public formMain()
        {
            InitializeComponent();

            labelListenIpPort.Text  = "Monitor Port: " + monitorPort.ToString();
            labelChannel.Text       = "Channel: " + monitorChannel.ToString();
            labelLayer.Text         = "Layer: " + monitorLayer.ToString();

            updateFilePath();
            updateFps();
            updateFramesPlayed();
            updateFramesRemaining();
            updateLoop();
            updatePaused();
        }

        private string calculateTimeDisplay(int totalFrames)
        {
            //Calculate hh:mm:ss:ff from frames and fps
            int frames = totalFrames % layerFps;
            int framesLeftToDisplay = totalFrames / layerFps;

            //Covert the remaining seconds to hh:mm:ss
            TimeSpan time = TimeSpan.FromSeconds(framesLeftToDisplay);
            string displayTime = time.ToString(@"hh\:mm\:ss\:") + frames.ToString("00");

            return displayTime;
        }

        private void updateFilePath()
        {
            labelFilePathValue.Text = layerFilePath;
        }

        private void updateFps()
        {
            labelFpsValue.Text = layerFps.ToString();
        }

        private void updateFramesPlayed()
        {
            labelFramesPlayedValue.Text = layerFramesPlayed.ToString();
            string timePlayedDisplay = calculateTimeDisplay(layerFramesPlayed);
            labelTimePlayedValue.Text = timePlayedDisplay;
        }

        private void updateFramesRemaining()
        {
            labelFramesRemainingValue.Text = layerFramesRemaining.ToString();
            string timeRemainingDisplay = calculateTimeDisplay(layerFramesRemaining);
            labelTimeRemainingValue.Text = timeRemainingDisplay;
        }

        private void updateLoop()
        {
            labelLoopValue.Text = layerLoop.ToString();
        }

        private void updatePaused()
        {
            labelPausedValue.Text = layerPaused.ToString();
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
    }
}