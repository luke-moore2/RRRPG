using RRRPG.Properties;

namespace RRRPG {
  public partial class FrmMain : Form {
    private int state;
    private Player player;
    private Opponent opponent;
    private Weapon weapon;

    public FrmMain() {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e) {
      btnDoIt.Visible = false;
      lblOpponentSpeak.Visible = false;
      lblPlayerSpeak.Visible = false;
      player = new Player(picPlayer, lblPlayerSpeak);
      opponent = new Opponent(picOpponent, lblOpponentSpeak);
      //weapon = ;
      state = -1;
    }

    private void btnStart_Click(object sender, EventArgs e) {
      player.Shutup();
      player.Idle();
      opponent.Idle();
      btnStart.Visible = false;
      opponent.TalkSmack();
      tmrDialog.Interval = 3500;
      tmrDialog.Enabled = true;
      state = 0;
    }

    private void tmrDialog_Tick(object sender, EventArgs e) {
      if (state == 0) {
        opponent.Shutup();
        player.TalkSmack();
        state = 1;
      }
      else if (state == 1) {
        opponent.Shutup();
        player.Shutup();
        player.TakeTurn();
        opponent.RemoveWand();
        btnDoIt.Visible = true;
        tmrDialog.Enabled = false;
        state = 2;
      }
      else if (state == 3) {
        player.SayOw();
        state = 4;
        tmrDialog.Interval = 2500;
      }
      else if (state == 4) {
        player.SayImBoned();
        btnStart.Visible = true;
        state = -1;
        tmrDialog.Enabled = false;
      }
      else if (state == 5) {
        player.Shutup();
        opponent.TakeTurn();
        state = 6;
      }
      else if (state == 6) {
        if (opponent.PullTrigger(weapon)) {
          state = 7;
        }
        else {
          state = 1;
        }
      }
      else if (state == 7) {
        opponent.SayOw();
        state = 8;
        tmrDialog.Interval = 2500;
      }
      else if (state == 8) {
        opponent.SayImBoned();
        btnStart.Visible = true;
        state = -1;
        tmrDialog.Enabled = false;
      }
    }

    private void btnDoIt_Click(object sender, EventArgs e) {
      if (player.PullTrigger(weapon)) {
        state = 3;
        tmrDialog.Interval = 2200;
        tmrDialog.Enabled = true;
      }
      else {
        state = 5;
        tmrDialog.Interval = 1500;
        tmrDialog.Enabled = true;
      }
      btnDoIt.Visible = false;
    }

    private void Kill() {
      picPlayer.Image = Resources.Bender_Kill;
      lblPlayerSpeak.Text = "Oh shit!";
      tmrKillBender.Enabled = true;
    }

    private void tmrKillBender_Tick(object sender, EventArgs e) {
      lblPlayerSpeak.Text = "Ow ow ow!!!";
      tmrKillBender.Enabled = false;
    }
  }
}