using System;
using System.Windows.Forms;

namespace CasparCG_Now_Playing
{
    public partial class formMain : Form
    {
        string monitorPort = System.Configuration.ConfigurationManager.AppSettings.Get("monitorPort");
        string monitorChannel = System.Configuration.ConfigurationManager.AppSettings.Get("monitorChannel");
        string monitorLayer = System.Configuration.ConfigurationManager.AppSettings.Get("monitorLayer");

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
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("http://curiousjames.net");
        }
    }
}