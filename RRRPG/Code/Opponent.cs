using RRRPG.Properties;
using System.ComponentModel;

namespace RRRPG {
  public class Opponent {
    private FortitudeType fortitude;
    private Stats stats;
    private PictureBox pic;
    private Label lblTalk;

    public Opponent(PictureBox pic, Label lblTalk) {
      this.pic = pic;
      this.lblTalk = lblTalk;
      stats = new(0.6f, 1, 0);
    }

    public void TalkSmack() {
      Talk("I will outlast you!");
    }

    public void SayOw() {
      Talk("This hurts more than I thought!");
    }

    public void SayImBoned() {
      Talk("That didn't go as planned");
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
      pic.Image = Resources.Wizard_With_Wand;
    }

    public void RemoveWand() {
      pic.Image = Resources.Wizard_No_Wand;
    }

    public void TakeTurn() {
      pic.Image = Resources.Wizard_Ready2;
    }

    public bool PullTrigger(Weapon weapon) {
      Random rand = new Random();
      float chance = rand.NextSingle();
      if (chance < 1 - stats.Luck) {
        pic.Image = Resources.Wizard_Kill;
        Talk("Well, that sucks!");
        return true;
      }
      else {
        pic.Image = Resources.Wizard_No_Wand;
        Talk("I knew I would live!");
        return false;
      }
    }
  }
}
