using RRRPG.Properties;
using RRRPGLib;
using System.DirectoryServices;
using System.Media;
<<<<<<< Updated upstream
=======
using System.Runtime.ExceptionServices;
using System.Security.Policy;
>>>>>>> Stashed changes

namespace RRRPG {
  public partial class FrmMain : Form {
    private SoundPlayer soundPlayer;
    private int state;
    private Character player;
    private Character opponent;
    private Weapon weapon;
    private Dictionary<WeaponType, (PictureBox pic, Label lbl)> weaponSelectMap;

    public FrmMain() {
      InitializeComponent();
      FormManager.openForms.Add(this);
    }

<<<<<<< Updated upstream
    private void FrmMain_Load(object sender, EventArgs e) {
      soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music);
      soundPlayer.PlayLooping();
      btnDoIt.Visible = false;
      lblOpponentSpeak.Visible = false;
      lblPlayerSpeak.Visible = false;
      weapon = Weapon.MakeWeapon(WeaponType.MAGIC_WAND);
      state = -1;
      weaponSelectMap = new() {
=======
        public void HUDRefresh()
        {
            AmmoLabel.Text = weapon.BulletsLoaded.ToString() + " / " + weapon.Chambers.ToString();
            float ChanceOfBullet = (1 - player.Stats.Luck / 3) * (weapon.BulletsLoaded / (float)weapon.Chambers);
            float ChanceItHits = ChanceOfBullet * (1 - weapon.ChanceOfMisfire / 2) * (1 - Math.Max(0, player.Stats.Reflex - weapon.Velocity));
            int ChanceSurvive = (int)((100) * (1 - ChanceItHits));
            SurvivalLabel.Text = ChanceSurvive.ToString() + " %";
            HealthLabel.Text = "Your Health: " + player.Stats.Health;
            FortLabel.Text = "Your Passive: " + player.fortitude;

        }

        public void ShowHUD()
        {
            AmmoText.Visible = true;
            SurvivalText.Visible = true;
            HealthLabel.Visible = true;
            AmmoLabel.Visible = true;
            SurvivalLabel.Visible = true;
            FortLabel.Visible = true;
            UpBtn.Visible = true;
            DownBtn.Visible = true;
            HUDRefresh();

        }

        public void UpdateStats()
        {
            if (player.fortitude == FortitudeType.HOLY)
            {
                player.Stats.Health += 5;
            }
            else if (player.fortitude == FortitudeType.LUCKY)
            {
                player.Stats.Luck = player.Stats.Luck * 1.05f;
            }
            else if (player.fortitude == FortitudeType.SHIFTY)
            {
                player.Stats.Reflex = player.Stats.Reflex * 1.1f;
            }
            else if (player.fortitude == FortitudeType.SCARED)
            {
                player.Stats.Health -= 5;
                player.Stats.Reflex = player.Stats.Reflex / 1.05f;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music);
            soundPlayer.PlayLooping();
            btnDoIt.Visible = false;
            lblOpponentSpeak.Visible = false;
            lblPlayerSpeak.Visible = false;
            weapon = Weapon.MakeWeapon(WeaponType.MAGIC_WAND);
            state = -1;
            weaponSelectMap = new() {
>>>>>>> Stashed changes
        {WeaponType.BOW, (picWeaponSelectBow, lblWeaponSelectBow) },
        {WeaponType.CORK_GUN, (picWeaponSelectCorkGun,lblWeaponSelectCorkGun) },
        {WeaponType.WATER_GUN, (picWeaponSelectWaterGun, lblWeaponSelectWaterGun) },
        {WeaponType.MAGIC_WAND, (picWeaponSelectMagicWand, lblWeaponSelectMagicWand) },
        {WeaponType.NERF_REVOLVER, (picWeaponSelectNerfRev, lblWeaponSelectNerfRev) },
      };
<<<<<<< Updated upstream
      SelectWeapon(WeaponType.MAGIC_WAND);
=======
            SelectWeapon(WeaponType.MAGIC_WAND);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ShowHUD();
            soundPlayer.Stop();
            player.Shutup();
            player.ShowIdle();
            opponent.ShowIdle();
            btnStart.Visible = false;
            opponent.SaySmack();
            tmrStateMachine.Interval = 3500;
            tmrStateMachine.Enabled = true;
            state = 0;
            panWeaponSelect.Visible = false;
        }

        private void tmrDialog_Tick(object sender, EventArgs e)
        {
            if (state == 0)
            {
                opponent.Shutup();
                player.SaySmack();
                state = 1;
            }
            else if (state == 1)
            {
                UpdateStats();
                HUDRefresh();
                opponent.Shutup();
                player.Shutup();
                player.ShowReady();
                opponent.ShowNoWeapon();
                btnDoIt.Visible = true;
                tmrStateMachine.Enabled = false;
                state = 2;
            }
            else if (state == 3)
            {
                player.SayOw();
                state = 4;
                tmrStateMachine.Interval = 2500;
            }
            else if (state == 4)
            {
                player.SayBoned();
                btnStart.Visible = true;
                tmrPlayMusicAfterGameOver.Enabled = true;
                panWeaponSelect.Visible = true;
                state = -1;
                tmrStateMachine.Enabled = false;
            }
            else if (state == 5)
            {
                player.Shutup();
                opponent.ShowReady();
                state = 6;
            }
            else if (state == 6)
            {
                if (opponent.PullTrigger(weapon))
                {
                    state = 7;
                }
                else
                {
                    state = 1;
                }
            }
            else if (state == 7)
            {
                opponent.SayOw();
                state = 8;
                tmrStateMachine.Interval = 2500;
            }
            else if (state == 8)
            {
                opponent.SayBoned();
                btnStart.Visible = true;
                tmrPlayMusicAfterGameOver.Enabled = true;
                panWeaponSelect.Visible = true;
                state = -1;
                tmrStateMachine.Enabled = false;
            }
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            if (player.PullTrigger(weapon))
            {
                state = 3;
                tmrStateMachine.Interval = 2200;
                tmrStateMachine.Enabled = true;
            }
            else
            {
                state = 5;
                tmrStateMachine.Interval = 1500;
                tmrStateMachine.Enabled = true;
            }
            btnDoIt.Visible = false;
        }

        private void SelectWeapon(WeaponType type)
        {
            Color selectedColor = Color.Yellow;
            foreach (var weaponSel in weaponSelectMap)
            {
                weaponSel.Value.pic.BackColor = Color.Black;
                weaponSel.Value.pic.BorderStyle = BorderStyle.None;
                weaponSel.Value.lbl.ForeColor = Color.White;
            }
            weaponSelectMap[type].pic.BackColor = selectedColor;
            weaponSelectMap[type].pic.BorderStyle = BorderStyle.Fixed3D;
            weaponSelectMap[type].lbl.ForeColor = selectedColor;
            weapon = Weapon.MakeWeapon(type);
            opponent = Character.MakeOpponent(type, picOpponent, lblOpponentSpeak);
            player = Character.MakePlayer(type, picPlayer, lblPlayerSpeak);
        }

        private void picWeaponSelectMagicWand_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.MAGIC_WAND);
        }

        private void picWeaponSelectCorkGun_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.CORK_GUN);
        }

        private void picWeaponSelectWaterGun_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.WATER_GUN);
        }

        private void picWeaponSelectNerfRev_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.NERF_REVOLVER);
        }

        private void picWeaponSelectBow_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.BOW);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.openForms.Remove(this);
            FormManager.CloseAll();
        }

        private void tmrPlayMusicAfterGameOver_Tick(object sender, EventArgs e)
        {
            if (btnStart.Visible)
            {
                soundPlayer.PlayLooping();
            }
            tmrPlayMusicAfterGameOver.Enabled = false;
        }

        private void HUDUp(object sender, EventArgs e)
        {
            if (weapon.BulletsLoaded < weapon.Chambers)
            {
                weapon.BulletsLoaded += 1;
                HUDRefresh();
            }

        }

        private void HUDDown(object sender, EventArgs e)
        {
            if (weapon.BulletsLoaded > 1)
            {
                weapon.BulletsLoaded -= 1;
                HUDRefresh();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes
    }

    private void btnStart_Click(object sender, EventArgs e) {
      soundPlayer.Stop();
      player.Shutup();
      player.ShowIdle();
      opponent.ShowIdle();
      btnStart.Visible = false;
      opponent.SaySmack();
      tmrStateMachine.Interval = 3500;
      tmrStateMachine.Enabled = true;
      state = 0;
      panWeaponSelect.Visible = false;
    }

    private void tmrDialog_Tick(object sender, EventArgs e) {
      if (state == 0) {
        opponent.Shutup();
        player.SaySmack();
        state = 1;
      }
      else if (state == 1) {
        opponent.Shutup();
        player.Shutup();
        player.ShowReady();
        opponent.ShowNoWeapon();
        btnDoIt.Visible = true;
        tmrStateMachine.Enabled = false;
        state = 2;
      }
      else if (state == 3) {
        player.SayOw();
        state = 4;
        tmrStateMachine.Interval = 2500;
      }
      else if (state == 4) {
        player.SayBoned();
        btnStart.Visible = true;
        tmrPlayMusicAfterGameOver.Enabled = true;
        panWeaponSelect.Visible = true;
        state = -1;
        tmrStateMachine.Enabled = false;
      }
      else if (state == 5) {
        player.Shutup();
        opponent.ShowReady();
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
        tmrStateMachine.Interval = 2500;
      }
      else if (state == 8) {
        opponent.SayBoned();
        btnStart.Visible = true;
        tmrPlayMusicAfterGameOver.Enabled = true;
        panWeaponSelect.Visible = true;
        state = -1;
        tmrStateMachine.Enabled = false;
      }
    }

    private void btnDoIt_Click(object sender, EventArgs e) {
      if (player.PullTrigger(weapon)) {
        state = 3;
        tmrStateMachine.Interval = 2200;
        tmrStateMachine.Enabled = true;
      }
      else {
        state = 5;
        tmrStateMachine.Interval = 1500;
        tmrStateMachine.Enabled = true;
      }
      btnDoIt.Visible = false;
    }

    private void SelectWeapon(WeaponType type) {
      Color selectedColor = Color.Yellow;
      foreach (var weaponSel in weaponSelectMap) {
        weaponSel.Value.pic.BackColor = Color.Black;
        weaponSel.Value.pic.BorderStyle = BorderStyle.None;
        weaponSel.Value.lbl.ForeColor = Color.White;
      }
      weaponSelectMap[type].pic.BackColor = selectedColor;
      weaponSelectMap[type].pic.BorderStyle = BorderStyle.Fixed3D;
      weaponSelectMap[type].lbl.ForeColor = selectedColor;
      weapon = Weapon.MakeWeapon(type);
      opponent = Character.MakeOpponent(type, picOpponent, lblOpponentSpeak);
      player = Character.MakePlayer(type, picPlayer, lblPlayerSpeak);
    }

    private void picWeaponSelectMagicWand_Click(object sender, EventArgs e) {
      SelectWeapon(WeaponType.MAGIC_WAND);
    }

    private void picWeaponSelectCorkGun_Click(object sender, EventArgs e) {
      SelectWeapon(WeaponType.CORK_GUN);
    }

    private void picWeaponSelectWaterGun_Click(object sender, EventArgs e) {
      SelectWeapon(WeaponType.WATER_GUN);
    }

    private void picWeaponSelectNerfRev_Click(object sender, EventArgs e) {
      SelectWeapon(WeaponType.NERF_REVOLVER);
    }

    private void picWeaponSelectBow_Click(object sender, EventArgs e) {
      SelectWeapon(WeaponType.BOW);
    }

    private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) {
      FormManager.openForms.Remove(this);
      FormManager.CloseAll();
    }

    private void tmrPlayMusicAfterGameOver_Tick(object sender, EventArgs e) {
      if (btnStart.Visible) {
        soundPlayer.PlayLooping();
      }
      tmrPlayMusicAfterGameOver.Enabled = false;
    }
  }
}