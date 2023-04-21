namespace RRRPG {
  partial class FrmMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.picOpponent = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      this.btnDoIt = new System.Windows.Forms.Button();
      this.lblPlayer = new System.Windows.Forms.Label();
      this.lblOpponent = new System.Windows.Forms.Label();
      this.picWeaponSelectWand = new System.Windows.Forms.PictureBox();
      this.lblWeaponSelected = new System.Windows.Forms.Label();
      this.panWeaponSelect = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnStart = new System.Windows.Forms.Button();
      this.lblOpponentSpeak = new System.Windows.Forms.Label();
      this.lblPlayerSpeak = new System.Windows.Forms.Label();
      this.tmrDialog = new System.Windows.Forms.Timer(this.components);
      this.tmrKillBender = new System.Windows.Forms.Timer(this.components);
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectWand)).BeginInit();
      this.panWeaponSelect.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // picOpponent
      // 
      this.picOpponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picOpponent.Image = global::RRRPG.Properties.Resources.Wizard_With_Wand;
      this.picOpponent.Location = new System.Drawing.Point(525, 120);
      this.picOpponent.Name = "picOpponent";
      this.picOpponent.Size = new System.Drawing.Size(526, 501);
      this.picOpponent.TabIndex = 0;
      this.picOpponent.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.Image = global::RRRPG.Properties.Resources.Bender;
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
      // picWeaponSelectWand
      // 
      this.picWeaponSelectWand.BackColor = System.Drawing.Color.Olive;
      this.picWeaponSelectWand.BackgroundImage = global::RRRPG.Properties.Resources.Wand;
      this.picWeaponSelectWand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectWand.Location = new System.Drawing.Point(12, 10);
      this.picWeaponSelectWand.Name = "picWeaponSelectWand";
      this.picWeaponSelectWand.Size = new System.Drawing.Size(128, 153);
      this.picWeaponSelectWand.TabIndex = 5;
      this.picWeaponSelectWand.TabStop = false;
      // 
      // lblWeaponSelected
      // 
      this.lblWeaponSelected.AutoSize = true;
      this.lblWeaponSelected.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelected.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelected.Location = new System.Drawing.Point(46, 166);
      this.lblWeaponSelected.Name = "lblWeaponSelected";
      this.lblWeaponSelected.Size = new System.Drawing.Size(57, 21);
      this.lblWeaponSelected.TabIndex = 6;
      this.lblWeaponSelected.Text = "Magic";
      // 
      // panWeaponSelect
      // 
      this.panWeaponSelect.BackColor = System.Drawing.Color.Black;
      this.panWeaponSelect.Controls.Add(this.label3);
      this.panWeaponSelect.Controls.Add(this.label2);
      this.panWeaponSelect.Controls.Add(this.label1);
      this.panWeaponSelect.Controls.Add(this.pictureBox2);
      this.panWeaponSelect.Controls.Add(this.pictureBox1);
      this.panWeaponSelect.Controls.Add(this.picWeaponSelectWand);
      this.panWeaponSelect.Controls.Add(this.lblWeaponSelected);
      this.panWeaponSelect.Location = new System.Drawing.Point(687, 636);
      this.panWeaponSelect.Name = "panWeaponSelect";
      this.panWeaponSelect.Size = new System.Drawing.Size(367, 229);
      this.panWeaponSelect.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Black;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(258, 165);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 21);
      this.label2.TabIndex = 10;
      this.label2.Text = "Water Gun";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Black;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(156, 165);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 21);
      this.label1.TabIndex = 9;
      this.label1.Text = "Cork Gun";
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackColor = System.Drawing.Color.Black;
      this.pictureBox2.BackgroundImage = global::RRRPG.Properties.Resources.water_gun;
      this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pictureBox2.Location = new System.Drawing.Point(252, 10);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(100, 152);
      this.pictureBox2.TabIndex = 8;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Black;
      this.pictureBox1.BackgroundImage = global::RRRPG.Properties.Resources.cork_gun;
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pictureBox1.Location = new System.Drawing.Point(146, 10);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 152);
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // btnStart
      // 
      this.btnStart.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnStart.Location = new System.Drawing.Point(314, 740);
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
      // tmrDialog
      // 
      this.tmrDialog.Interval = 40;
      this.tmrDialog.Tick += new System.EventHandler(this.tmrDialog_Tick);
      // 
      // tmrKillBender
      // 
      this.tmrKillBender.Interval = 1500;
      this.tmrKillBender.Tick += new System.EventHandler(this.tmrKillBender_Tick);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.Silver;
      this.label3.Location = new System.Drawing.Point(125, 195);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(158, 30);
      this.label3.TabIndex = 11;
      this.label3.Text = "Weapon Select";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
      this.Name = "FrmMain";
      this.Text = "Russian Roulette";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectWand)).EndInit();
      this.panWeaponSelect.ResumeLayout(false);
      this.panWeaponSelect.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private PictureBox picOpponent;
    private PictureBox picPlayer;
    private Button btnDoIt;
    private Label lblPlayer;
    private Label lblOpponent;
    private PictureBox picWeaponSelectWand;
    private Label lblWeaponSelected;
    private Panel panWeaponSelect;
    private Button btnStart;
    private Label lblOpponentSpeak;
    private Label lblPlayerSpeak;
    private System.Windows.Forms.Timer tmrDialog;
    private System.Windows.Forms.Timer tmrKillBender;
    private PictureBox pictureBox1;
    private Label label2;
    private Label label1;
    private PictureBox pictureBox2;
    private Label label3;
  }
}