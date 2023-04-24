using RRRPG.Properties;
using System.Media;

namespace RRRPG;

public partial class FrmTitle : Form {
  private SoundPlayer soundPlayer;
  public FrmTitle() {
    InitializeComponent();
  }

  private void btnPlay_Click(object sender, EventArgs e) {
    Hide();
    soundPlayer.Stop();
    FrmMain frmMain = new FrmMain();
    frmMain.ShowDialog();
    FormManager.openForms.Add(frmMain);
  }

  private void FrmTitle_Load(object sender, EventArgs e) {
    soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music_3);
    soundPlayer.PlayLooping();
    FormManager.openForms.Add(this);
  }

  private void FrmTitle_FormClosed(object sender, FormClosedEventArgs e) {
    FormManager.openForms.Remove(this);
    FormManager.CloseAll();
  }
}
