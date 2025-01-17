﻿namespace JocysCom.TextToSpeech.Monitor.Controls.Options
{
    partial class ElevenLabsVoicesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevenLabsVoicesUserControl));
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.SecretKeyTextBox = new System.Windows.Forms.TextBox();
            this.SecurityGroupBox = new System.Windows.Forms.GroupBox();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.HelpGroupBox = new System.Windows.Forms.GroupBox();
            this.PricingLabel = new System.Windows.Forms.Label();
            this.Help2Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AwsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.SpeakButton = new System.Windows.Forms.Button();
            this.RefreshVoicesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.VoicesComboBox = new System.Windows.Forms.ComboBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SecurityGroupBox.SuspendLayout();
            this.HelpGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ServiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.AutoSize = true;
            this.SecretKeyLabel.Location = new System.Drawing.Point(16, 41);
            this.SecretKeyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(88, 25);
            this.SecretKeyLabel.TabIndex = 15;
            this.SecretKeyLabel.Text = "API Key";
            // 
            // SecretKeyTextBox
            // 
            this.SecretKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecretKeyTextBox.Location = new System.Drawing.Point(154, 36);
            this.SecretKeyTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.SecretKeyTextBox.Name = "SecretKeyTextBox";
            this.SecretKeyTextBox.Size = new System.Drawing.Size(594, 31);
            this.SecretKeyTextBox.TabIndex = 13;
            this.SecretKeyTextBox.UseSystemPasswordChar = true;
            // 
            // SecurityGroupBox
            // 
            this.SecurityGroupBox.Controls.Add(this.SecretKeyLabel);
            this.SecurityGroupBox.Controls.Add(this.SecretKeyTextBox);
            this.SecurityGroupBox.Location = new System.Drawing.Point(6, 6);
            this.SecurityGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.SecurityGroupBox.Name = "SecurityGroupBox";
            this.SecurityGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.SecurityGroupBox.Size = new System.Drawing.Size(760, 90);
            this.SecurityGroupBox.TabIndex = 17;
            this.SecurityGroupBox.TabStop = false;
            this.SecurityGroupBox.Text = "Security";
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HelpLabel.Location = new System.Drawing.Point(0, 0);
            this.HelpLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.HelpLabel.Size = new System.Drawing.Size(309, 40);
            this.HelpLabel.TabIndex = 18;
            this.HelpLabel.Text = "1. Create ElevenLabs Account:";
            // 
            // HelpGroupBox
            // 
            this.HelpGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpGroupBox.AutoSize = true;
            this.HelpGroupBox.Controls.Add(this.PricingLabel);
            this.HelpGroupBox.Controls.Add(this.Help2Label);
            this.HelpGroupBox.Controls.Add(this.panel1);
            this.HelpGroupBox.Controls.Add(this.linkLabel1);
            this.HelpGroupBox.Location = new System.Drawing.Point(778, 6);
            this.HelpGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.HelpGroupBox.Name = "HelpGroupBox";
            this.HelpGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.HelpGroupBox.Size = new System.Drawing.Size(740, 448);
            this.HelpGroupBox.TabIndex = 19;
            this.HelpGroupBox.TabStop = false;
            this.HelpGroupBox.Text = "How To Use EvenLabs TTS Voices";
            // 
            // PricingLabel
            // 
            this.PricingLabel.AutoSize = true;
            this.PricingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PricingLabel.Location = new System.Drawing.Point(6, 174);
            this.PricingLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PricingLabel.Name = "PricingLabel";
            this.PricingLabel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.PricingLabel.Size = new System.Drawing.Size(614, 90);
            this.PricingLabel.TabIndex = 18;
            this.PricingLabel.Text = "Free tier: 10 000 characters per month (~40 WoW quests).\r\n$5/month: 30,000 charac" +
    "ters per month (~120 WoW quests).\r\n$22/month: 100,000 characters per month (~400" +
    " WoW quests).";
            // 
            // Help2Label
            // 
            this.Help2Label.AutoSize = true;
            this.Help2Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help2Label.Location = new System.Drawing.Point(6, 74);
            this.Help2Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Help2Label.Name = "Help2Label";
            this.Help2Label.Size = new System.Drawing.Size(711, 100);
            this.Help2Label.TabIndex = 20;
            this.Help2Label.Text = resources.GetString("Help2Label.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AwsLinkLabel);
            this.panel1.Controls.Add(this.HelpLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 44);
            this.panel1.TabIndex = 21;
            // 
            // AwsLinkLabel
            // 
            this.AwsLinkLabel.AutoSize = true;
            this.AwsLinkLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AwsLinkLabel.Location = new System.Drawing.Point(309, 0);
            this.AwsLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AwsLinkLabel.Name = "AwsLinkLabel";
            this.AwsLinkLabel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.AwsLinkLabel.Size = new System.Drawing.Size(252, 40);
            this.AwsLinkLabel.TabIndex = 19;
            this.AwsLinkLabel.TabStop = true;
            this.AwsLinkLabel.Text = "https://beta.elevenlabs.io";
            this.AwsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AwsLinkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 315);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(374, 25);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://beta.elevenlabs.io/subscription";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AwsLinkLabel_LinkClicked);
            // 
            // ServiceGroupBox
            // 
            this.ServiceGroupBox.Controls.Add(this.StatusTextBox);
            this.ServiceGroupBox.Controls.Add(this.SpeakButton);
            this.ServiceGroupBox.Controls.Add(this.RefreshVoicesButton);
            this.ServiceGroupBox.Controls.Add(this.label3);
            this.ServiceGroupBox.Controls.Add(this.MessageLabel);
            this.ServiceGroupBox.Controls.Add(this.VoicesComboBox);
            this.ServiceGroupBox.Controls.Add(this.MessageTextBox);
            this.ServiceGroupBox.Controls.Add(this.label4);
            this.ServiceGroupBox.Location = new System.Drawing.Point(6, 108);
            this.ServiceGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.ServiceGroupBox.Name = "ServiceGroupBox";
            this.ServiceGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.ServiceGroupBox.Size = new System.Drawing.Size(760, 196);
            this.ServiceGroupBox.TabIndex = 17;
            this.ServiceGroupBox.TabStop = false;
            this.ServiceGroupBox.Text = "Service";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTextBox.Location = new System.Drawing.Point(142, 141);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(602, 31);
            this.StatusTextBox.TabIndex = 19;
            // 
            // SpeakButton
            // 
            this.SpeakButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeakButton.Enabled = false;
            this.SpeakButton.Location = new System.Drawing.Point(598, 88);
            this.SpeakButton.Margin = new System.Windows.Forms.Padding(6);
            this.SpeakButton.Name = "SpeakButton";
            this.SpeakButton.Size = new System.Drawing.Size(150, 44);
            this.SpeakButton.TabIndex = 18;
            this.SpeakButton.Text = "Speak";
            this.SpeakButton.UseVisualStyleBackColor = true;
            this.SpeakButton.Click += new System.EventHandler(this.SpeakButton_Click);
            // 
            // RefreshVoicesButton
            // 
            this.RefreshVoicesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshVoicesButton.Location = new System.Drawing.Point(598, 36);
            this.RefreshVoicesButton.Margin = new System.Windows.Forms.Padding(6);
            this.RefreshVoicesButton.Name = "RefreshVoicesButton";
            this.RefreshVoicesButton.Size = new System.Drawing.Size(150, 44);
            this.RefreshVoicesButton.TabIndex = 18;
            this.RefreshVoicesButton.Text = "Refresh";
            this.RefreshVoicesButton.UseVisualStyleBackColor = true;
            this.RefreshVoicesButton.Click += new System.EventHandler(this.RefreshVoicesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(16, 97);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(100, 25);
            this.MessageLabel.TabIndex = 15;
            this.MessageLabel.Text = "Message";
            // 
            // VoicesComboBox
            // 
            this.VoicesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VoicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoicesComboBox.FormattingEnabled = true;
            this.VoicesComboBox.Location = new System.Drawing.Point(142, 39);
            this.VoicesComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.VoicesComboBox.Name = "VoicesComboBox";
            this.VoicesComboBox.Size = new System.Drawing.Size(440, 33);
            this.VoicesComboBox.TabIndex = 17;
            this.VoicesComboBox.SelectedIndexChanged += new System.EventHandler(this.VoicesComboBox_SelectedIndexChanged);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextBox.Location = new System.Drawing.Point(142, 91);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(440, 31);
            this.MessageTextBox.TabIndex = 13;
            this.MessageTextBox.Text = "Hello world! Test Text to speech.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Voices";
            // 
            // ElevenLabsVoicesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HelpGroupBox);
            this.Controls.Add(this.ServiceGroupBox);
            this.Controls.Add(this.SecurityGroupBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ElevenLabsVoicesUserControl";
            this.Size = new System.Drawing.Size(1524, 502);
            this.SecurityGroupBox.ResumeLayout(false);
            this.SecurityGroupBox.PerformLayout();
            this.HelpGroupBox.ResumeLayout(false);
            this.HelpGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ServiceGroupBox.ResumeLayout(false);
            this.ServiceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SecretKeyLabel;
        private System.Windows.Forms.TextBox SecretKeyTextBox;
        private System.Windows.Forms.GroupBox SecurityGroupBox;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.GroupBox HelpGroupBox;
        private System.Windows.Forms.LinkLabel AwsLinkLabel;
        private System.Windows.Forms.Label Help2Label;
        private System.Windows.Forms.GroupBox ServiceGroupBox;
        private System.Windows.Forms.Button RefreshVoicesButton;
        private System.Windows.Forms.ComboBox VoicesComboBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SpeakButton;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PricingLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}
