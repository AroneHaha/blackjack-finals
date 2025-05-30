﻿namespace FinalBlackJack
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            tittleText = new Label();
            playNowButton = new Button();
            exitButton = new Button();
            loadingPanel = new Panel();
            loadingText2 = new Label();
            loadingBar = new ProgressBar();
            form1Panel = new Panel();
            termsPanel = new Panel();
            label2 = new Label();
            termsTextPanel = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            acceptButton = new Button();
            declineButton = new Button();
            loadingPanel.SuspendLayout();
            form1Panel.SuspendLayout();
            termsPanel.SuspendLayout();
            termsTextPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tittleText
            // 
            tittleText.Anchor = AnchorStyles.Top;
            tittleText.AutoSize = true;
            tittleText.BackColor = Color.Transparent;
            tittleText.Font = new Font("Haettenschweiler", 85F);
            tittleText.ForeColor = Color.DarkOrange;
            tittleText.Location = new Point(166, 44);
            tittleText.Name = "tittleText";
            tittleText.Size = new Size(684, 119);
            tittleText.TabIndex = 0;
            tittleText.Text = "Black Jack Deluxe";
            tittleText.Click += tittleText_Click;
            // 
            // playNowButton
            // 
            playNowButton.BackColor = Color.Transparent;
            playNowButton.Cursor = Cursors.Hand;
            playNowButton.FlatAppearance.BorderSize = 0;
            playNowButton.FlatAppearance.MouseDownBackColor = Color.Green;
            playNowButton.FlatAppearance.MouseOverBackColor = Color.Green;
            playNowButton.FlatStyle = FlatStyle.Flat;
            playNowButton.Font = new Font("Haettenschweiler", 35F);
            playNowButton.ForeColor = Color.White;
            playNowButton.Location = new Point(97, 280);
            playNowButton.Name = "playNowButton";
            playNowButton.Size = new Size(215, 68);
            playNowButton.TabIndex = 1;
            playNowButton.Text = "PLAY NOW";
            playNowButton.UseVisualStyleBackColor = false;
            playNowButton.Click += playNowButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = Color.Red;
            exitButton.FlatAppearance.MouseOverBackColor = Color.Red;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ControlLight;
            exitButton.Location = new Point(150, 354);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(108, 35);
            exitButton.TabIndex = 2;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // loadingPanel
            // 
            loadingPanel.BackColor = Color.Black;
            loadingPanel.BackgroundImageLayout = ImageLayout.Stretch;
            loadingPanel.Controls.Add(loadingText2);
            loadingPanel.Controls.Add(loadingBar);
            loadingPanel.Dock = DockStyle.Fill;
            loadingPanel.Location = new Point(0, 0);
            loadingPanel.Name = "loadingPanel";
            loadingPanel.Size = new Size(984, 636);
            loadingPanel.TabIndex = 3;
            loadingPanel.Paint += loadingPanel_Paint;
            // 
            // loadingText2
            // 
            loadingText2.AutoSize = true;
            loadingText2.BackColor = Color.Transparent;
            loadingText2.Font = new Font("Haettenschweiler", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadingText2.ForeColor = Color.White;
            loadingText2.Location = new Point(439, 349);
            loadingText2.Name = "loadingText2";
            loadingText2.Size = new Size(115, 23);
            loadingText2.TabIndex = 2;
            loadingText2.Text = "Loading Assets...";
            // 
            // loadingBar
            // 
            loadingBar.Location = new Point(250, 312);
            loadingBar.Name = "loadingBar";
            loadingBar.Size = new Size(476, 23);
            loadingBar.TabIndex = 1;
            // 
            // form1Panel
            // 
            form1Panel.BackgroundImage = (Image)resources.GetObject("form1Panel.BackgroundImage");
            form1Panel.BackgroundImageLayout = ImageLayout.Stretch;
            form1Panel.Controls.Add(loadingPanel);
            form1Panel.Controls.Add(exitButton);
            form1Panel.Controls.Add(termsPanel);
            form1Panel.Controls.Add(tittleText);
            form1Panel.Controls.Add(playNowButton);
            form1Panel.Dock = DockStyle.Fill;
            form1Panel.Location = new Point(0, 0);
            form1Panel.Name = "form1Panel";
            form1Panel.Size = new Size(984, 636);
            form1Panel.TabIndex = 4;
            // 
            // termsPanel
            // 
            termsPanel.BackColor = Color.LightGray;
            termsPanel.Controls.Add(label2);
            termsPanel.Controls.Add(termsTextPanel);
            termsPanel.Controls.Add(acceptButton);
            termsPanel.Controls.Add(declineButton);
            termsPanel.Location = new Point(264, 63);
            termsPanel.Name = "termsPanel";
            termsPanel.Size = new Size(456, 509);
            termsPanel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Haettenschweiler", 33F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(67, 19);
            label2.Name = "label2";
            label2.Size = new Size(334, 45);
            label2.TabIndex = 3;
            label2.Text = "TERMS AND AGREEMENT";
            // 
            // termsTextPanel
            // 
            termsTextPanel.AutoScroll = true;
            termsTextPanel.BackColor = Color.WhiteSmoke;
            termsTextPanel.Controls.Add(label12);
            termsTextPanel.Controls.Add(label11);
            termsTextPanel.Controls.Add(label10);
            termsTextPanel.Controls.Add(label9);
            termsTextPanel.Controls.Add(label8);
            termsTextPanel.Controls.Add(label7);
            termsTextPanel.Controls.Add(label6);
            termsTextPanel.Controls.Add(label5);
            termsTextPanel.Controls.Add(label4);
            termsTextPanel.Controls.Add(label3);
            termsTextPanel.Controls.Add(label1);
            termsTextPanel.Location = new Point(38, 77);
            termsTextPanel.Name = "termsTextPanel";
            termsTextPanel.Size = new Size(390, 353);
            termsTextPanel.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(50, 13);
            label12.Name = "label12";
            label12.Size = new Size(276, 114);
            label12.TabIndex = 10;
            label12.Text = resources.GetString("label12.Text");
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(39, 806);
            label11.Name = "label11";
            label11.Size = new Size(305, 60);
            label11.TabIndex = 9;
            label11.Text = "If you have any questions about these terms, \r\nplease contact, the developer.\r\n\r\n";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(144, 774);
            label10.Name = "label10";
            label10.Size = new Size(85, 28);
            label10.TabIndex = 8;
            label10.Text = "Contact";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(29, 609);
            label9.Name = "label9";
            label9.Size = new Size(322, 140);
            label9.TabIndex = 7;
            label9.Text = resources.GetString("label9.Text");
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(80, 577);
            label8.Name = "label8";
            label8.Size = new Size(217, 28);
            label8.TabIndex = 6;
            label8.Text = "Limitation of Liability";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(33, 432);
            label7.Name = "label7";
            label7.Size = new Size(316, 120);
            label7.TabIndex = 5;
            label7.Text = resources.GetString("label7.Text");
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(106, 398);
            label6.Name = "label6";
            label6.Size = new Size(171, 28);
            label6.TabIndex = 4;
            label6.Text = "Play Responsibly";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 299);
            label5.Name = "label5";
            label5.Size = new Size(310, 80);
            label5.TabIndex = 3;
            label5.Text = "BlackJack Deluxe is meant for entertainment \r\npurposes only. No real money or gambling is \r\ninvolved. You must be at least 13 years old \r\nto play.";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(135, 269);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 2;
            label4.Text = "Game Use";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(50, 189);
            label3.Name = "label3";
            label3.Size = new Size(289, 60);
            label3.TabIndex = 1;
            label3.Text = "By playing BlackJack Deluxe, you agree to \r\nfollow,these Terms and Conditions. If you \r\ndo not agree, please do not use the game.\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(85, 157);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 0;
            label1.Text = "Acceptance of Terms";
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.Green;
            acceptButton.ForeColor = Color.White;
            acceptButton.Location = new Point(243, 452);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(158, 39);
            acceptButton.TabIndex = 1;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // declineButton
            // 
            declineButton.BackColor = Color.Red;
            declineButton.ForeColor = Color.White;
            declineButton.Location = new Point(71, 452);
            declineButton.Name = "declineButton";
            declineButton.Size = new Size(158, 39);
            declineButton.TabIndex = 1;
            declineButton.Text = "Decline";
            declineButton.UseVisualStyleBackColor = false;
            declineButton.Click += declineButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(984, 636);
            Controls.Add(form1Panel);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Black Jack Deluxe";
            Load += StartForm_Load;
            loadingPanel.ResumeLayout(false);
            loadingPanel.PerformLayout();
            form1Panel.ResumeLayout(false);
            form1Panel.PerformLayout();
            termsPanel.ResumeLayout(false);
            termsPanel.PerformLayout();
            termsTextPanel.ResumeLayout(false);
            termsTextPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label tittleText;
        private Button playNowButton;
        private Button exitButton;
        private Panel loadingPanel;
        private Label loadingText2;
        private ProgressBar loadingBar;
        private Panel form1Panel;
        private Panel termsPanel;
        private Panel termsTextPanel;
        private Button acceptButton;
        private Button declineButton;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label10;
        private Label label12;
    }
}
