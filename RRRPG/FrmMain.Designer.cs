namespace RRRPG
{
    partial class FrmMain
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
            label1 = new Label();
            AmmoLabel = new Label();
            label4 = new Label();
            SurvivalLabel = new Label();
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
            UpBtn.Click += HUDUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(119, 712);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 13;
            label1.Text = "Ammo";
            label1.Click += label1_Click;
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(73, 786);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 15;
            label4.Text = "Chance of Survival:";
            // 
            // SurvivalLabel
            // 
            SurvivalLabel.AutoSize = true;
            SurvivalLabel.BackColor = Color.White;
            SurvivalLabel.Location = new Point(133, 828);
            SurvivalLabel.Name = "SurvivalLabel";
            SurvivalLabel.Size = new Size(13, 20);
            SurvivalLabel.TabIndex = 16;
            SurvivalLabel.Text = " ";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1240, 1055);
            Controls.Add(SurvivalLabel);
            Controls.Add(label4);
            Controls.Add(AmmoLabel);
            Controls.Add(label1);
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
        private Label label1;
        private Label AmmoLabel;
        private Label label4;
        private Label SurvivalLabel;
    }
}