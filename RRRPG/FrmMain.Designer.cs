namespace RRRPG {
  partial class FrmMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

<<<<<<< Updated upstream
    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
=======
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            picOpponent = new PictureBox();
            picPlayer = new PictureBox();
            btnDoIt = new Button();
            lblPlayer = new Label();
            lblOpponent = new Label();
            picWeaponSelectMagicWand = new PictureBox();
            lblWeaponSelectMagicWand = new Label();
            panWeaponSelect = new Panel();
            lblWeaponSelectBow = new Label();
            picWeaponSelectBow = new PictureBox();
            lblWeaponSelectNerfRev = new Label();
            picWeaponSelectNerfRev = new PictureBox();
            label3 = new Label();
            lblWeaponSelectWaterGun = new Label();
            lblWeaponSelectCorkGun = new Label();
            picWeaponSelectWaterGun = new PictureBox();
            picWeaponSelectCorkGun = new PictureBox();
            btnStart = new Button();
            lblOpponentSpeak = new Label();
            lblPlayerSpeak = new Label();
            tmrStateMachine = new System.Windows.Forms.Timer(components);
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            DownBtn = new Button();
            UpBtn = new Button();
            AmmoText = new Label();
            AmmoLabel = new Label();
            SurvivalText = new Label();
            SurvivalLabel = new Label();
            HealthLabel = new Label();
            FortLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).BeginInit();
            panWeaponSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).BeginInit();
            SuspendLayout();
            // 
            // picOpponent
            // 
            picOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent.Location = new Point(600, 160);
            picOpponent.Margin = new Padding(3, 4, 3, 4);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(601, 668);
            picOpponent.TabIndex = 0;
            picOpponent.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Image = Properties.Resources.Img_Bender_Idle;
            picPlayer.Location = new Point(14, 115);
            picPlayer.Margin = new Padding(3, 4, 3, 4);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(559, 796);
            picPlayer.TabIndex = 1;
            picPlayer.TabStop = false;
            // 
            // btnDoIt
            // 
            btnDoIt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoIt.Location = new Point(183, 927);
            btnDoIt.Margin = new Padding(3, 4, 3, 4);
            btnDoIt.Name = "btnDoIt";
            btnDoIt.Size = new Size(257, 93);
            btnDoIt.TabIndex = 2;
            btnDoIt.Text = "Try Your Luck!";
            btnDoIt.UseVisualStyleBackColor = true;
            btnDoIt.Click += btnDoIt_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(242, 64);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(105, 41);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Player";
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.ForeColor = Color.White;
            lblOpponent.Location = new Point(870, 67);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(161, 41);
            lblOpponent.TabIndex = 4;
            lblOpponent.Text = "Opponent";
            // 
            // picWeaponSelectMagicWand
            // 
            picWeaponSelectMagicWand.BackColor = Color.Black;
            picWeaponSelectMagicWand.BackgroundImage = Properties.Resources.Img_Magic_Wand;
            picWeaponSelectMagicWand.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectMagicWand.Location = new Point(14, 13);
            picWeaponSelectMagicWand.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
            picWeaponSelectMagicWand.Size = new Size(146, 204);
            picWeaponSelectMagicWand.TabIndex = 5;
            picWeaponSelectMagicWand.TabStop = false;
            picWeaponSelectMagicWand.Click += picWeaponSelectMagicWand_Click;
            // 
            // lblWeaponSelectMagicWand
            // 
            lblWeaponSelectMagicWand.AutoSize = true;
            lblWeaponSelectMagicWand.BackColor = Color.Black;
            lblWeaponSelectMagicWand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectMagicWand.ForeColor = Color.White;
            lblWeaponSelectMagicWand.Location = new Point(53, 221);
            lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
            lblWeaponSelectMagicWand.Size = new Size(70, 28);
            lblWeaponSelectMagicWand.TabIndex = 6;
            lblWeaponSelectMagicWand.Text = "Magic";
            // 
            // panWeaponSelect
            // 
            panWeaponSelect.BackColor = Color.Black;
            panWeaponSelect.Controls.Add(lblWeaponSelectBow);
            panWeaponSelect.Controls.Add(picWeaponSelectBow);
            panWeaponSelect.Controls.Add(lblWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(picWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(label3);
            panWeaponSelect.Controls.Add(lblWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(lblWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(picWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectMagicWand);
            panWeaponSelect.Controls.Add(lblWeaponSelectMagicWand);
            panWeaponSelect.Location = new Point(579, 848);
            panWeaponSelect.Margin = new Padding(3, 4, 3, 4);
            panWeaponSelect.Name = "panWeaponSelect";
            panWeaponSelect.Size = new Size(647, 305);
            panWeaponSelect.TabIndex = 7;
            // 
            // lblWeaponSelectBow
            // 
            lblWeaponSelectBow.AutoSize = true;
            lblWeaponSelectBow.BackColor = Color.Black;
            lblWeaponSelectBow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectBow.ForeColor = Color.White;
            lblWeaponSelectBow.Location = new Point(571, 221);
            lblWeaponSelectBow.Name = "lblWeaponSelectBow";
            lblWeaponSelectBow.Size = new Size(53, 28);
            lblWeaponSelectBow.TabIndex = 15;
            lblWeaponSelectBow.Text = "Bow";
            // 
            // picWeaponSelectBow
            // 
            picWeaponSelectBow.BackColor = Color.Black;
            picWeaponSelectBow.BackgroundImage = Properties.Resources.Img_Bow;
            picWeaponSelectBow.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectBow.Location = new Point(533, 15);
            picWeaponSelectBow.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectBow.Name = "picWeaponSelectBow";
            picWeaponSelectBow.Size = new Size(114, 203);
            picWeaponSelectBow.TabIndex = 14;
            picWeaponSelectBow.TabStop = false;
            picWeaponSelectBow.Click += picWeaponSelectBow_Click;
            // 
            // lblWeaponSelectNerfRev
            // 
            lblWeaponSelectNerfRev.AutoSize = true;
            lblWeaponSelectNerfRev.BackColor = Color.Black;
            lblWeaponSelectNerfRev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectNerfRev.ForeColor = Color.White;
            lblWeaponSelectNerfRev.Location = new Point(401, 221);
            lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
            lblWeaponSelectNerfRev.Size = new Size(144, 28);
            lblWeaponSelectNerfRev.TabIndex = 13;
            lblWeaponSelectNerfRev.Text = "Nerf Revolver";
            // 
            // picWeaponSelectNerfRev
            // 
            picWeaponSelectNerfRev.BackColor = Color.Black;
            picWeaponSelectNerfRev.BackgroundImage = Properties.Resources.Img_Nerf_Revolver;
            picWeaponSelectNerfRev.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectNerfRev.Location = new Point(409, 15);
            picWeaponSelectNerfRev.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
            picWeaponSelectNerfRev.Size = new Size(114, 203);
            picWeaponSelectNerfRev.TabIndex = 12;
            picWeaponSelectNerfRev.TabStop = false;
            picWeaponSelectNerfRev.Click += picWeaponSelectNerfRev_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(235, 260);
            label3.Name = "label3";
            label3.Size = new Size(207, 37);
            label3.TabIndex = 11;
            label3.Text = "Weapon Select";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeaponSelectWaterGun
            // 
            lblWeaponSelectWaterGun.AutoSize = true;
            lblWeaponSelectWaterGun.BackColor = Color.Black;
            lblWeaponSelectWaterGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectWaterGun.ForeColor = Color.White;
            lblWeaponSelectWaterGun.Location = new Point(295, 220);
            lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
            lblWeaponSelectWaterGun.Size = new Size(113, 28);
            lblWeaponSelectWaterGun.TabIndex = 10;
            lblWeaponSelectWaterGun.Text = "Water Gun";
            // 
            // lblWeaponSelectCorkGun
            // 
            lblWeaponSelectCorkGun.AutoSize = true;
            lblWeaponSelectCorkGun.BackColor = Color.Black;
            lblWeaponSelectCorkGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectCorkGun.ForeColor = Color.White;
            lblWeaponSelectCorkGun.Location = new Point(178, 220);
            lblWeaponSelectCorkGun.Name = "lblWeaponSelectCorkGun";
            lblWeaponSelectCorkGun.Size = new Size(99, 28);
            lblWeaponSelectCorkGun.TabIndex = 9;
            lblWeaponSelectCorkGun.Text = "Cork Gun";
            // 
            // picWeaponSelectWaterGun
            // 
            picWeaponSelectWaterGun.BackColor = Color.Black;
            picWeaponSelectWaterGun.BackgroundImage = Properties.Resources.Img_Water_Gun;
            picWeaponSelectWaterGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectWaterGun.Location = new Point(288, 13);
            picWeaponSelectWaterGun.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
            picWeaponSelectWaterGun.Size = new Size(114, 203);
            picWeaponSelectWaterGun.TabIndex = 8;
            picWeaponSelectWaterGun.TabStop = false;
            picWeaponSelectWaterGun.Click += picWeaponSelectWaterGun_Click;
            // 
            // picWeaponSelectCorkGun
            // 
            picWeaponSelectCorkGun.BackColor = Color.Black;
            picWeaponSelectCorkGun.BackgroundImage = Properties.Resources.Img_Cork_Gun;
            picWeaponSelectCorkGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectCorkGun.Location = new Point(167, 13);
            picWeaponSelectCorkGun.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectCorkGun.Name = "picWeaponSelectCorkGun";
            picWeaponSelectCorkGun.Size = new Size(114, 203);
            picWeaponSelectCorkGun.TabIndex = 7;
            picWeaponSelectCorkGun.TabStop = false;
            picWeaponSelectCorkGun.Click += picWeaponSelectCorkGun_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(242, 1024);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(257, 93);
            btnStart.TabIndex = 8;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblOpponentSpeak
            // 
            lblOpponentSpeak.AutoSize = true;
            lblOpponentSpeak.BackColor = Color.White;
            lblOpponentSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponentSpeak.Location = new Point(666, 133);
            lblOpponentSpeak.Name = "lblOpponentSpeak";
            lblOpponentSpeak.Size = new Size(263, 41);
            lblOpponentSpeak.TabIndex = 9;
            lblOpponentSpeak.Text = "I will outlast you!";
            // 
            // lblPlayerSpeak
            // 
            lblPlayerSpeak.AutoSize = true;
            lblPlayerSpeak.BackColor = Color.White;
            lblPlayerSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerSpeak.Location = new Point(377, 211);
            lblPlayerSpeak.Name = "lblPlayerSpeak";
            lblPlayerSpeak.Size = new Size(355, 41);
            lblPlayerSpeak.TabIndex = 10;
            lblPlayerSpeak.Text = "Bite my shiny metal ass!";
            // 
            // tmrStateMachine
            // 
            tmrStateMachine.Interval = 40;
            tmrStateMachine.Tick += tmrDialog_Tick;
            // 
            // tmrPlayMusicAfterGameOver
            // 
            tmrPlayMusicAfterGameOver.Interval = 2000;
            tmrPlayMusicAfterGameOver.Tick += tmrPlayMusicAfterGameOver_Tick;
            // 
            // DownBtn
            // 
            DownBtn.Location = new Point(40, 758);
            DownBtn.Name = "DownBtn";
            DownBtn.Size = new Size(50, 25);
            DownBtn.TabIndex = 11;
            DownBtn.Text = "-";
            DownBtn.UseVisualStyleBackColor = true;
            DownBtn.Visible = false;
            DownBtn.Click += HUDDown;
            // 
            // UpBtn
            // 
            UpBtn.Location = new Point(183, 753);
            UpBtn.Name = "UpBtn";
            UpBtn.Size = new Size(57, 25);
            UpBtn.TabIndex = 12;
            UpBtn.Text = "+";
            UpBtn.UseVisualStyleBackColor = true;
            UpBtn.Visible = false;
            UpBtn.Click += HUDUp;
            // 
            // AmmoText
            // 
            AmmoText.AutoSize = true;
            AmmoText.BackColor = Color.White;
            AmmoText.Location = new Point(114, 727);
            AmmoText.Name = "AmmoText";
            AmmoText.Size = new Size(54, 20);
            AmmoText.TabIndex = 13;
            AmmoText.Text = "Ammo";
            AmmoText.Visible = false;
            AmmoText.Click += label1_Click;
            // 
            // AmmoLabel
            // 
            AmmoLabel.AutoSize = true;
            AmmoLabel.BackColor = Color.White;
            AmmoLabel.Location = new Point(133, 758);
            AmmoLabel.Name = "AmmoLabel";
            AmmoLabel.Size = new Size(13, 20);
            AmmoLabel.TabIndex = 14;
            AmmoLabel.Text = " ";
            AmmoLabel.Visible = false;
            // 
            // SurvivalText
            // 
            SurvivalText.AutoSize = true;
            SurvivalText.BackColor = Color.White;
            SurvivalText.Location = new Point(73, 786);
            SurvivalText.Name = "SurvivalText";
            SurvivalText.Size = new Size(133, 20);
            SurvivalText.TabIndex = 15;
            SurvivalText.Text = "Chance of Survival:";
            SurvivalText.Visible = false;
            // 
            // SurvivalLabel
            // 
            SurvivalLabel.AutoSize = true;
            SurvivalLabel.BackColor = Color.White;
            SurvivalLabel.Location = new Point(133, 808);
            SurvivalLabel.Name = "SurvivalLabel";
            SurvivalLabel.Size = new Size(13, 20);
            SurvivalLabel.TabIndex = 16;
            SurvivalLabel.Text = " ";
            SurvivalLabel.Visible = false;
            // 
            // HealthLabel
            // 
            HealthLabel.AutoSize = true;
            HealthLabel.BackColor = Color.White;
            HealthLabel.ForeColor = SystemColors.ActiveCaptionText;
            HealthLabel.Location = new Point(112, 838);
            HealthLabel.Name = "HealthLabel";
            HealthLabel.Size = new Size(56, 20);
            HealthLabel.TabIndex = 17;
            HealthLabel.Text = "Health:";
            HealthLabel.Visible = false;
            // 
            // FortLabel
            // 
            FortLabel.AutoSize = true;
            FortLabel.BackColor = Color.White;
            FortLabel.ForeColor = SystemColors.ActiveCaptionText;
            FortLabel.Location = new Point(112, 863);
            FortLabel.Name = "FortLabel";
            FortLabel.Size = new Size(58, 20);
            FortLabel.TabIndex = 18;
            FortLabel.Text = "Passive:";
            FortLabel.Visible = false;
            FortLabel.Click += label2_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1240, 1055);
            Controls.Add(FortLabel);
            Controls.Add(HealthLabel);
            Controls.Add(SurvivalLabel);
            Controls.Add(SurvivalText);
            Controls.Add(AmmoLabel);
            Controls.Add(AmmoText);
            Controls.Add(UpBtn);
            Controls.Add(DownBtn);
            Controls.Add(lblPlayerSpeak);
            Controls.Add(lblOpponentSpeak);
            Controls.Add(btnStart);
            Controls.Add(panWeaponSelect);
            Controls.Add(lblOpponent);
            Controls.Add(lblPlayer);
            Controls.Add(btnDoIt);
            Controls.Add(picPlayer);
            Controls.Add(picOpponent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            Text = "Russian Roulette RPG";
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).EndInit();
            panWeaponSelect.ResumeLayout(false);
            panWeaponSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picOpponent;
        private PictureBox picPlayer;
        private Button btnDoIt;
        private Label lblPlayer;
        private Label lblOpponent;
        private PictureBox picWeaponSelectMagicWand;
        private Label lblWeaponSelectMagicWand;
        private Panel panWeaponSelect;
        private Button btnStart;
        private Label lblOpponentSpeak;
        private Label lblPlayerSpeak;
        private System.Windows.Forms.Timer tmrStateMachine;
        private PictureBox picWeaponSelectCorkGun;
        private Label lblWeaponSelectWaterGun;
        private Label lblWeaponSelectCorkGun;
        private PictureBox picWeaponSelectWaterGun;
        private Label label3;
        private Label lblWeaponSelectBow;
        private PictureBox picWeaponSelectBow;
        private Label lblWeaponSelectNerfRev;
        private PictureBox picWeaponSelectNerfRev;
        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private Button DownBtn;
        private Button UpBtn;
        private Label AmmoText;
        private Label AmmoLabel;
        private Label SurvivalText;
        private Label SurvivalLabel;
        private Label HealthLabel;
        private Label FortLabel;
>>>>>>> Stashed changes
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.picOpponent = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      this.btnDoIt = new System.Windows.Forms.Button();
      this.lblPlayer = new System.Windows.Forms.Label();
      this.lblOpponent = new System.Windows.Forms.Label();
      this.picWeaponSelectMagicWand = new System.Windows.Forms.PictureBox();
      this.lblWeaponSelectMagicWand = new System.Windows.Forms.Label();
      this.panWeaponSelect = new System.Windows.Forms.Panel();
      this.lblWeaponSelectBow = new System.Windows.Forms.Label();
      this.picWeaponSelectBow = new System.Windows.Forms.PictureBox();
      this.lblWeaponSelectNerfRev = new System.Windows.Forms.Label();
      this.picWeaponSelectNerfRev = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lblWeaponSelectWaterGun = new System.Windows.Forms.Label();
      this.lblWeaponSelectCorkGun = new System.Windows.Forms.Label();
      this.picWeaponSelectWaterGun = new System.Windows.Forms.PictureBox();
      this.picWeaponSelectCorkGun = new System.Windows.Forms.PictureBox();
      this.btnStart = new System.Windows.Forms.Button();
      this.lblOpponentSpeak = new System.Windows.Forms.Label();
      this.lblPlayerSpeak = new System.Windows.Forms.Label();
      this.tmrStateMachine = new System.Windows.Forms.Timer(this.components);
      this.tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectMagicWand)).BeginInit();
      this.panWeaponSelect.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectBow)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectNerfRev)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectWaterGun)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectCorkGun)).BeginInit();
      this.SuspendLayout();
      // 
      // picOpponent
      // 
      this.picOpponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picOpponent.Location = new System.Drawing.Point(525, 120);
      this.picOpponent.Name = "picOpponent";
      this.picOpponent.Size = new System.Drawing.Size(526, 501);
      this.picOpponent.TabIndex = 0;
      this.picOpponent.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.Image = global::RRRPG.Properties.Resources.Img_Bender_Idle;
      this.picPlayer.Location = new System.Drawing.Point(12, 86);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(489, 597);
      this.picPlayer.TabIndex = 1;
      this.picPlayer.TabStop = false;
      // 
      // btnDoIt
      // 
      this.btnDoIt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnDoIt.Location = new System.Drawing.Point(160, 695);
      this.btnDoIt.Name = "btnDoIt";
      this.btnDoIt.Size = new System.Drawing.Size(225, 70);
      this.btnDoIt.TabIndex = 2;
      this.btnDoIt.Text = "Try Your Luck!";
      this.btnDoIt.UseVisualStyleBackColor = true;
      this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
      // 
      // lblPlayer
      // 
      this.lblPlayer.AutoSize = true;
      this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblPlayer.ForeColor = System.Drawing.Color.White;
      this.lblPlayer.Location = new System.Drawing.Point(212, 48);
      this.lblPlayer.Name = "lblPlayer";
      this.lblPlayer.Size = new System.Drawing.Size(85, 32);
      this.lblPlayer.TabIndex = 3;
      this.lblPlayer.Text = "Player";
      // 
      // lblOpponent
      // 
      this.lblOpponent.AutoSize = true;
      this.lblOpponent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblOpponent.ForeColor = System.Drawing.Color.White;
      this.lblOpponent.Location = new System.Drawing.Point(761, 50);
      this.lblOpponent.Name = "lblOpponent";
      this.lblOpponent.Size = new System.Drawing.Size(129, 32);
      this.lblOpponent.TabIndex = 4;
      this.lblOpponent.Text = "Opponent";
      // 
      // picWeaponSelectMagicWand
      // 
      this.picWeaponSelectMagicWand.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectMagicWand.BackgroundImage = global::RRRPG.Properties.Resources.Img_Magic_Wand;
      this.picWeaponSelectMagicWand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectMagicWand.Location = new System.Drawing.Point(12, 10);
      this.picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
      this.picWeaponSelectMagicWand.Size = new System.Drawing.Size(128, 153);
      this.picWeaponSelectMagicWand.TabIndex = 5;
      this.picWeaponSelectMagicWand.TabStop = false;
      this.picWeaponSelectMagicWand.Click += new System.EventHandler(this.picWeaponSelectMagicWand_Click);
      // 
      // lblWeaponSelectMagicWand
      // 
      this.lblWeaponSelectMagicWand.AutoSize = true;
      this.lblWeaponSelectMagicWand.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectMagicWand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectMagicWand.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectMagicWand.Location = new System.Drawing.Point(46, 166);
      this.lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
      this.lblWeaponSelectMagicWand.Size = new System.Drawing.Size(57, 21);
      this.lblWeaponSelectMagicWand.TabIndex = 6;
      this.lblWeaponSelectMagicWand.Text = "Magic";
      // 
      // panWeaponSelect
      // 
      this.panWeaponSelect.BackColor = System.Drawing.Color.Black;
      this.panWeaponSelect.Controls.Add(this.lblWeaponSelectBow);
      this.panWeaponSelect.Controls.Add(this.picWeaponSelectBow);
      this.panWeaponSelect.Controls.Add(this.lblWeaponSelectNerfRev);
      this.panWeaponSelect.Controls.Add(this.picWeaponSelectNerfRev);
      this.panWeaponSelect.Controls.Add(this.label3);
      this.panWeaponSelect.Controls.Add(this.lblWeaponSelectWaterGun);
      this.panWeaponSelect.Controls.Add(this.lblWeaponSelectCorkGun);
      this.panWeaponSelect.Controls.Add(this.picWeaponSelectWaterGun);
      this.panWeaponSelect.Controls.Add(this.picWeaponSelectCorkGun);
      this.panWeaponSelect.Controls.Add(this.picWeaponSelectMagicWand);
      this.panWeaponSelect.Controls.Add(this.lblWeaponSelectMagicWand);
      this.panWeaponSelect.Location = new System.Drawing.Point(507, 636);
      this.panWeaponSelect.Name = "panWeaponSelect";
      this.panWeaponSelect.Size = new System.Drawing.Size(566, 229);
      this.panWeaponSelect.TabIndex = 7;
      // 
      // lblWeaponSelectBow
      // 
      this.lblWeaponSelectBow.AutoSize = true;
      this.lblWeaponSelectBow.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectBow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectBow.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectBow.Location = new System.Drawing.Point(500, 166);
      this.lblWeaponSelectBow.Name = "lblWeaponSelectBow";
      this.lblWeaponSelectBow.Size = new System.Drawing.Size(43, 21);
      this.lblWeaponSelectBow.TabIndex = 15;
      this.lblWeaponSelectBow.Text = "Bow";
      // 
      // picWeaponSelectBow
      // 
      this.picWeaponSelectBow.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectBow.BackgroundImage = global::RRRPG.Properties.Resources.Img_Bow;
      this.picWeaponSelectBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectBow.Location = new System.Drawing.Point(466, 11);
      this.picWeaponSelectBow.Name = "picWeaponSelectBow";
      this.picWeaponSelectBow.Size = new System.Drawing.Size(100, 152);
      this.picWeaponSelectBow.TabIndex = 14;
      this.picWeaponSelectBow.TabStop = false;
      this.picWeaponSelectBow.Click += new System.EventHandler(this.picWeaponSelectBow_Click);
      // 
      // lblWeaponSelectNerfRev
      // 
      this.lblWeaponSelectNerfRev.AutoSize = true;
      this.lblWeaponSelectNerfRev.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectNerfRev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectNerfRev.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectNerfRev.Location = new System.Drawing.Point(351, 166);
      this.lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
      this.lblWeaponSelectNerfRev.Size = new System.Drawing.Size(115, 21);
      this.lblWeaponSelectNerfRev.TabIndex = 13;
      this.lblWeaponSelectNerfRev.Text = "Nerf Revolver";
      // 
      // picWeaponSelectNerfRev
      // 
      this.picWeaponSelectNerfRev.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectNerfRev.BackgroundImage = global::RRRPG.Properties.Resources.Img_Nerf_Revolver;
      this.picWeaponSelectNerfRev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectNerfRev.Location = new System.Drawing.Point(358, 11);
      this.picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
      this.picWeaponSelectNerfRev.Size = new System.Drawing.Size(100, 152);
      this.picWeaponSelectNerfRev.TabIndex = 12;
      this.picWeaponSelectNerfRev.TabStop = false;
      this.picWeaponSelectNerfRev.Click += new System.EventHandler(this.picWeaponSelectNerfRev_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.Silver;
      this.label3.Location = new System.Drawing.Point(206, 195);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(158, 30);
      this.label3.TabIndex = 11;
      this.label3.Text = "Weapon Select";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblWeaponSelectWaterGun
      // 
      this.lblWeaponSelectWaterGun.AutoSize = true;
      this.lblWeaponSelectWaterGun.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectWaterGun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectWaterGun.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectWaterGun.Location = new System.Drawing.Point(258, 165);
      this.lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
      this.lblWeaponSelectWaterGun.Size = new System.Drawing.Size(90, 21);
      this.lblWeaponSelectWaterGun.TabIndex = 10;
      this.lblWeaponSelectWaterGun.Text = "Water Gun";
      // 
      // lblWeaponSelectCorkGun
      // 
      this.lblWeaponSelectCorkGun.AutoSize = true;
      this.lblWeaponSelectCorkGun.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectCorkGun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectCorkGun.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectCorkGun.Location = new System.Drawing.Point(156, 165);
      this.lblWeaponSelectCorkGun.Name = "lblWeaponSelectCorkGun";
      this.lblWeaponSelectCorkGun.Size = new System.Drawing.Size(80, 21);
      this.lblWeaponSelectCorkGun.TabIndex = 9;
      this.lblWeaponSelectCorkGun.Text = "Cork Gun";
      // 
      // picWeaponSelectWaterGun
      // 
      this.picWeaponSelectWaterGun.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectWaterGun.BackgroundImage = global::RRRPG.Properties.Resources.Img_Water_Gun;
      this.picWeaponSelectWaterGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectWaterGun.Location = new System.Drawing.Point(252, 10);
      this.picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
      this.picWeaponSelectWaterGun.Size = new System.Drawing.Size(100, 152);
      this.picWeaponSelectWaterGun.TabIndex = 8;
      this.picWeaponSelectWaterGun.TabStop = false;
      this.picWeaponSelectWaterGun.Click += new System.EventHandler(this.picWeaponSelectWaterGun_Click);
      // 
      // picWeaponSelectCorkGun
      // 
      this.picWeaponSelectCorkGun.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectCorkGun.BackgroundImage = global::RRRPG.Properties.Resources.Img_Cork_Gun;
      this.picWeaponSelectCorkGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectCorkGun.Location = new System.Drawing.Point(146, 10);
      this.picWeaponSelectCorkGun.Name = "picWeaponSelectCorkGun";
      this.picWeaponSelectCorkGun.Size = new System.Drawing.Size(100, 152);
      this.picWeaponSelectCorkGun.TabIndex = 7;
      this.picWeaponSelectCorkGun.TabStop = false;
      this.picWeaponSelectCorkGun.Click += new System.EventHandler(this.picWeaponSelectCorkGun_Click);
      // 
      // btnStart
      // 
      this.btnStart.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnStart.Location = new System.Drawing.Point(212, 768);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(225, 70);
      this.btnStart.TabIndex = 8;
      this.btnStart.Text = "START";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lblOpponentSpeak
      // 
      this.lblOpponentSpeak.AutoSize = true;
      this.lblOpponentSpeak.BackColor = System.Drawing.Color.White;
      this.lblOpponentSpeak.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblOpponentSpeak.Location = new System.Drawing.Point(583, 100);
      this.lblOpponentSpeak.Name = "lblOpponentSpeak";
      this.lblOpponentSpeak.Size = new System.Drawing.Size(213, 32);
      this.lblOpponentSpeak.TabIndex = 9;
      this.lblOpponentSpeak.Text = "I will outlast you!";
      // 
      // lblPlayerSpeak
      // 
      this.lblPlayerSpeak.AutoSize = true;
      this.lblPlayerSpeak.BackColor = System.Drawing.Color.White;
      this.lblPlayerSpeak.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblPlayerSpeak.Location = new System.Drawing.Point(330, 158);
      this.lblPlayerSpeak.Name = "lblPlayerSpeak";
      this.lblPlayerSpeak.Size = new System.Drawing.Size(288, 32);
      this.lblPlayerSpeak.TabIndex = 10;
      this.lblPlayerSpeak.Text = "Bite my shiny metal ass!";
      // 
      // tmrStateMachine
      // 
      this.tmrStateMachine.Interval = 40;
      this.tmrStateMachine.Tick += new System.EventHandler(this.tmrDialog_Tick);
      // 
      // tmrPlayMusicAfterGameOver
      // 
      this.tmrPlayMusicAfterGameOver.Interval = 2000;
      this.tmrPlayMusicAfterGameOver.Tick += new System.EventHandler(this.tmrPlayMusicAfterGameOver_Tick);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(1085, 887);
      this.Controls.Add(this.lblPlayerSpeak);
      this.Controls.Add(this.lblOpponentSpeak);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.panWeaponSelect);
      this.Controls.Add(this.lblOpponent);
      this.Controls.Add(this.lblPlayer);
      this.Controls.Add(this.btnDoIt);
      this.Controls.Add(this.picPlayer);
      this.Controls.Add(this.picOpponent);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmMain";
      this.Text = "Russian Roulette RPG";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectMagicWand)).EndInit();
      this.panWeaponSelect.ResumeLayout(false);
      this.panWeaponSelect.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectBow)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectNerfRev)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectWaterGun)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectCorkGun)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private PictureBox picOpponent;
    private PictureBox picPlayer;
    private Button btnDoIt;
    private Label lblPlayer;
    private Label lblOpponent;
    private PictureBox picWeaponSelectMagicWand;
    private Label lblWeaponSelectMagicWand;
    private Panel panWeaponSelect;
    private Button btnStart;
    private Label lblOpponentSpeak;
    private Label lblPlayerSpeak;
    private System.Windows.Forms.Timer tmrStateMachine;
    private PictureBox picWeaponSelectCorkGun;
    private Label lblWeaponSelectWaterGun;
    private Label lblWeaponSelectCorkGun;
    private PictureBox picWeaponSelectWaterGun;
    private Label label3;
    private Label lblWeaponSelectBow;
    private PictureBox picWeaponSelectBow;
    private Label lblWeaponSelectNerfRev;
    private PictureBox picWeaponSelectNerfRev;
    private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
  }
}