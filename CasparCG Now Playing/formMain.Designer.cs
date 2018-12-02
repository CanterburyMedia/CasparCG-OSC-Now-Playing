namespace CasparCG_Now_Playing
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.labelCuriousjamesnet = new System.Windows.Forms.LinkLabel();
            this.labelChannel = new System.Windows.Forms.Label();
            this.labelLayer = new System.Windows.Forms.Label();
            this.labelListenIpPort = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelLoop = new System.Windows.Forms.Label();
            this.labelPaused = new System.Windows.Forms.Label();
            this.labelTimeRemaining = new System.Windows.Forms.Label();
            this.labelTimePlayed = new System.Windows.Forms.Label();
            this.labelFramesRemaining = new System.Windows.Forms.Label();
            this.labelFps = new System.Windows.Forms.Label();
            this.labelFilePathValue = new System.Windows.Forms.Label();
            this.labelFpsValue = new System.Windows.Forms.Label();
            this.labelFramesPlayed = new System.Windows.Forms.Label();
            this.labelFramesPlayedValue = new System.Windows.Forms.Label();
            this.labelFramesRemainingValue = new System.Windows.Forms.Label();
            this.labelTimePlayedValue = new System.Windows.Forms.Label();
            this.labelTimeRemainingValue = new System.Windows.Forms.Label();
            this.labelPausedValue = new System.Windows.Forms.Label();
            this.labelLoopValue = new System.Windows.Forms.Label();
            this.buttonOscStartStop = new System.Windows.Forms.Button();
            this.labelLastMsgValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCuriousjamesnet
            // 
            this.labelCuriousjamesnet.AutoSize = true;
            this.labelCuriousjamesnet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCuriousjamesnet.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCuriousjamesnet.Location = new System.Drawing.Point(0, 305);
            this.labelCuriousjamesnet.Name = "labelCuriousjamesnet";
            this.labelCuriousjamesnet.Size = new System.Drawing.Size(134, 13);
            this.labelCuriousjamesnet.TabIndex = 1;
            this.labelCuriousjamesnet.TabStop = true;
            this.labelCuriousjamesnet.Text = "Made by CuriousJames.net";
            this.labelCuriousjamesnet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelCuriousjamesnet_LinkClicked);
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelChannel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChannel.Location = new System.Drawing.Point(486, 9);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(139, 27);
            this.labelChannel.TabIndex = 2;
            this.labelChannel.Text = "Channel: ??";
            // 
            // labelLayer
            // 
            this.labelLayer.AutoSize = true;
            this.labelLayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLayer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLayer.Location = new System.Drawing.Point(642, 9);
            this.labelLayer.Name = "labelLayer";
            this.labelLayer.Size = new System.Drawing.Size(112, 27);
            this.labelLayer.TabIndex = 3;
            this.labelLayer.Text = "Layer: ??";
            // 
            // labelListenIpPort
            // 
            this.labelListenIpPort.AutoSize = true;
            this.labelListenIpPort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelListenIpPort.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListenIpPort.Location = new System.Drawing.Point(105, 9);
            this.labelListenIpPort.Name = "labelListenIpPort";
            this.labelListenIpPort.Size = new System.Drawing.Size(244, 27);
            this.labelListenIpPort.TabIndex = 4;
            this.labelListenIpPort.Text = "Monitoring Port: 6250";
            // 
            // labelFilePath
            // 
            this.labelFilePath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePath.Location = new System.Drawing.Point(127, 0);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFilePath.Size = new System.Drawing.Size(92, 23);
            this.labelFilePath.TabIndex = 5;
            this.labelFilePath.Text = "File Path";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.Controls.Add(this.labelLoop, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.labelPaused, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.labelTimeRemaining, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.labelTimePlayed, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labelFramesRemaining, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelFps, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelFilePath, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelFilePathValue, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelFpsValue, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelFramesPlayed, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelFramesPlayedValue, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelFramesRemainingValue, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.labelTimePlayedValue, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.labelTimeRemainingValue, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.labelPausedValue, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.labelLoopValue, 1, 8);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 57);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(742, 213);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // labelLoop
            // 
            this.labelLoop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLoop.AutoSize = true;
            this.labelLoop.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoop.Location = new System.Drawing.Point(79, 189);
            this.labelLoop.Name = "labelLoop";
            this.labelLoop.Size = new System.Drawing.Size(140, 23);
            this.labelLoop.TabIndex = 19;
            this.labelLoop.Text = "Loop Enabled";
            // 
            // labelPaused
            // 
            this.labelPaused.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaused.AutoSize = true;
            this.labelPaused.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaused.Location = new System.Drawing.Point(142, 168);
            this.labelPaused.Name = "labelPaused";
            this.labelPaused.Size = new System.Drawing.Size(77, 20);
            this.labelPaused.TabIndex = 17;
            this.labelPaused.Text = "Paused";
            // 
            // labelTimeRemaining
            // 
            this.labelTimeRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTimeRemaining.AutoSize = true;
            this.labelTimeRemaining.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeRemaining.Location = new System.Drawing.Point(54, 131);
            this.labelTimeRemaining.Name = "labelTimeRemaining";
            this.labelTimeRemaining.Size = new System.Drawing.Size(165, 23);
            this.labelTimeRemaining.TabIndex = 15;
            this.labelTimeRemaining.Text = "Time Remaining";
            // 
            // labelTimePlayed
            // 
            this.labelTimePlayed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTimePlayed.AutoSize = true;
            this.labelTimePlayed.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimePlayed.Location = new System.Drawing.Point(93, 93);
            this.labelTimePlayed.Name = "labelTimePlayed";
            this.labelTimePlayed.Size = new System.Drawing.Size(126, 23);
            this.labelTimePlayed.TabIndex = 13;
            this.labelTimePlayed.Text = "Time Played";
            // 
            // labelFramesRemaining
            // 
            this.labelFramesRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFramesRemaining.AutoSize = true;
            this.labelFramesRemaining.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFramesRemaining.Location = new System.Drawing.Point(32, 69);
            this.labelFramesRemaining.Name = "labelFramesRemaining";
            this.labelFramesRemaining.Size = new System.Drawing.Size(187, 23);
            this.labelFramesRemaining.TabIndex = 11;
            this.labelFramesRemaining.Text = "Frames Remaining";
            // 
            // labelFps
            // 
            this.labelFps.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFps.AutoSize = true;
            this.labelFps.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFps.Location = new System.Drawing.Point(174, 23);
            this.labelFps.Name = "labelFps";
            this.labelFps.Size = new System.Drawing.Size(45, 23);
            this.labelFps.TabIndex = 8;
            this.labelFps.Text = "FPS";
            // 
            // labelFilePathValue
            // 
            this.labelFilePathValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFilePathValue.AutoSize = true;
            this.labelFilePathValue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePathValue.Location = new System.Drawing.Point(225, 0);
            this.labelFilePathValue.Name = "labelFilePathValue";
            this.labelFilePathValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFilePathValue.Size = new System.Drawing.Size(92, 23);
            this.labelFilePathValue.TabIndex = 6;
            this.labelFilePathValue.Text = "File Path";
            this.labelFilePathValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFpsValue
            // 
            this.labelFpsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFpsValue.AutoSize = true;
            this.labelFpsValue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFpsValue.Location = new System.Drawing.Point(225, 23);
            this.labelFpsValue.Name = "labelFpsValue";
            this.labelFpsValue.Size = new System.Drawing.Size(45, 23);
            this.labelFpsValue.TabIndex = 7;
            this.labelFpsValue.Text = "FPS";
            // 
            // labelFramesPlayed
            // 
            this.labelFramesPlayed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFramesPlayed.AutoSize = true;
            this.labelFramesPlayed.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFramesPlayed.Location = new System.Drawing.Point(71, 46);
            this.labelFramesPlayed.Name = "labelFramesPlayed";
            this.labelFramesPlayed.Size = new System.Drawing.Size(148, 23);
            this.labelFramesPlayed.TabIndex = 9;
            this.labelFramesPlayed.Text = "Frames Played";
            // 
            // labelFramesPlayedValue
            // 
            this.labelFramesPlayedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFramesPlayedValue.AutoSize = true;
            this.labelFramesPlayedValue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFramesPlayedValue.Location = new System.Drawing.Point(225, 46);
            this.labelFramesPlayedValue.Name = "labelFramesPlayedValue";
            this.labelFramesPlayedValue.Size = new System.Drawing.Size(148, 23);
            this.labelFramesPlayedValue.TabIndex = 10;
            this.labelFramesPlayedValue.Text = "Frames Played";
            // 
            // labelFramesRemainingValue
            // 
            this.labelFramesRemainingValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFramesRemainingValue.AutoSize = true;
            this.labelFramesRemainingValue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFramesRemainingValue.Location = new System.Drawing.Point(225, 69);
            this.labelFramesRemainingValue.Name = "labelFramesRemainingValue";
            this.labelFramesRemainingValue.Size = new System.Drawing.Size(187, 23);
            this.labelFramesRemainingValue.TabIndex = 12;
            this.labelFramesRemainingValue.Text = "Frames Remaining";
            // 
            // labelTimePlayedValue
            // 
            this.labelTimePlayedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTimePlayedValue.AutoSize = true;
            this.labelTimePlayedValue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimePlayedValue.Location = new System.Drawing.Point(225, 93);
            this.labelTimePlayedValue.Name = "labelTimePlayedValue";
            this.labelTimePlayedValue.Size = new System.Drawing.Size(126, 23);
            this.labelTimePlayedValue.TabIndex = 14;
            this.labelTimePlayedValue.Text = "Time Played";
            // 
            // labelTimeRemainingValue
            // 
            this.labelTimeRemainingValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTimeRemainingValue.AutoSize = true;
            this.labelTimeRemainingValue.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeRemainingValue.ForeColor = System.Drawing.Color.Yellow;
            this.labelTimeRemainingValue.Location = new System.Drawing.Point(225, 120);
            this.labelTimeRemainingValue.Name = "labelTimeRemainingValue";
            this.labelTimeRemainingValue.Size = new System.Drawing.Size(357, 45);
            this.labelTimeRemainingValue.TabIndex = 16;
            this.labelTimeRemainingValue.Text = "Time Remaining";
            // 
            // labelPausedValue
            // 
            this.labelPausedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPausedValue.AutoSize = true;
            this.labelPausedValue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPausedValue.Location = new System.Drawing.Point(225, 168);
            this.labelPausedValue.Name = "labelPausedValue";
            this.labelPausedValue.Size = new System.Drawing.Size(77, 20);
            this.labelPausedValue.TabIndex = 18;
            this.labelPausedValue.Text = "Paused";
            // 
            // labelLoopValue
            // 
            this.labelLoopValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLoopValue.AutoSize = true;
            this.labelLoopValue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoopValue.Location = new System.Drawing.Point(225, 189);
            this.labelLoopValue.Name = "labelLoopValue";
            this.labelLoopValue.Size = new System.Drawing.Size(140, 23);
            this.labelLoopValue.TabIndex = 20;
            this.labelLoopValue.Text = "Loop Enabled";
            // 
            // buttonOscStartStop
            // 
            this.buttonOscStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOscStartStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOscStartStop.Location = new System.Drawing.Point(12, 9);
            this.buttonOscStartStop.Name = "buttonOscStartStop";
            this.buttonOscStartStop.Size = new System.Drawing.Size(77, 27);
            this.buttonOscStartStop.TabIndex = 7;
            this.buttonOscStartStop.Text = "Start OSC";
            this.buttonOscStartStop.UseVisualStyleBackColor = true;
            this.buttonOscStartStop.Click += new System.EventHandler(this.buttonOscStartStop_Click);
            // 
            // labelLastMsgValue
            // 
            this.labelLastMsgValue.AutoSize = true;
            this.labelLastMsgValue.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastMsgValue.Location = new System.Drawing.Point(241, 273);
            this.labelLastMsgValue.Name = "labelLastMsgValue";
            this.labelLastMsgValue.Size = new System.Drawing.Size(143, 23);
            this.labelLastMsgValue.TabIndex = 8;
            this.labelLastMsgValue.Text = "labelLastMsgValue";
            this.labelLastMsgValue.Visible = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(768, 318);
            this.Controls.Add(this.labelLastMsgValue);
            this.Controls.Add(this.buttonOscStartStop);
            this.Controls.Add(this.labelCuriousjamesnet);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelListenIpPort);
            this.Controls.Add(this.labelLayer);
            this.Controls.Add(this.labelChannel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.Text = "OSC CasparCG Now Playing";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel labelCuriousjamesnet;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelLayer;
        private System.Windows.Forms.Label labelListenIpPort;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelFramesRemaining;
        private System.Windows.Forms.Label labelFps;
        private System.Windows.Forms.Label labelFilePathValue;
        private System.Windows.Forms.Label labelFpsValue;
        private System.Windows.Forms.Label labelFramesPlayed;
        private System.Windows.Forms.Label labelFramesPlayedValue;
        private System.Windows.Forms.Label labelFramesRemainingValue;
        private System.Windows.Forms.Label labelLoop;
        private System.Windows.Forms.Label labelPaused;
        private System.Windows.Forms.Label labelTimeRemaining;
        private System.Windows.Forms.Label labelTimePlayed;
        private System.Windows.Forms.Label labelTimePlayedValue;
        private System.Windows.Forms.Label labelTimeRemainingValue;
        private System.Windows.Forms.Label labelPausedValue;
        private System.Windows.Forms.Label labelLoopValue;
        private System.Windows.Forms.Button buttonOscStartStop;
        private System.Windows.Forms.Label labelLastMsgValue;
    }
}