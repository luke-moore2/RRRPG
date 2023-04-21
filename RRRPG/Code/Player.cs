using RRRPG.Properties;
using System.ComponentModel;

namespace RRRPG {
  public class Player {
    private Stats stats;
    private PictureBox pic;
    private Label lblTalk;

    public Player(PictureBox pic, Label lblTalk) {
      this.pic = pic;
      this.lblTalk = lblTalk;
      stats = new(0.8f, 1, 0);
    }

    public void TalkSmack() {
      Talk("Bite my shiny metal ass!");
    }

    public void SayOw() {
      Talk("Ow ow ow!!!");
    }

    public void SayImBoned() {
      Talk("Well, I'm boned!");
    }

    private void Talk(string msg) {
      lblTalk.Text = msg;
      lblTalk.Visible = true;
    }

    public void Shutup() {
      lblTalk.Text = "";
      lblTalk.Visible = false;
    }

    public void Idle() {
      pic.Image = Resources.Bender;
    }

    public void TakeTurn() {
      pic.Image = Resources.Bender_Ready;
    }

    public bool PullTrigger(Weapon weapon) {
      Random rand = new Random();
      float chance = rand.NextSingle();
      if (chance < 1 - stats.Luck) {
        pic.Image = Resources.Bender_Kill;
        Talk("Oh shit!");
        return true;
      }
      else {
        pic.Image = Resources.Bender;
        Talk("I'm the greatest!");
        return false;
      }
    }
  }
}
