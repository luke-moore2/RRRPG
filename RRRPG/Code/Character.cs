using RRRPG.Properties;
using ImgState = RRRPG.CharacterImgStateType;
using TalkState = RRRPG.CharacterTalkStateType;

namespace RRRPG;

public enum CharacterImgStateType {
  IDLE,
  NO_WEAPON,
  READY,
  KILL
}

public enum CharacterTalkStateType {
  TALK_SMACK,
  SAY_OW,
  BONED,
  GUN_WENT_OFF,
  SURVIVED
}

public class Character {
  private FortitudeType fortitude;
  public Stats Stats { get; private set; }
  private PictureBox pic;
  private Label lblTalk;
  private Dictionary<ImgState, Bitmap> imgMap;
  private Dictionary<TalkState, (string dialog, UnmanagedMemoryStream audio)> dialogMap;

  public Character() : this(null, null) {

  }
  public Character(PictureBox pic, Label lblTalk) {
    this.pic = pic;
    this.lblTalk = lblTalk;
    this.fortitude = FortitudeType.NORMAL;
  }

  public static Character MakeOpponent(WeaponType weaponType, PictureBox pic, Label lblTalk) {
    Character c = weaponType switch {
      WeaponType.MAGIC_WAND => MakeMagicWandOpponent(),
      WeaponType.NERF_REVOLVER => MakeNerfRevolverOpponent(),
      WeaponType.BOW => MakeBowOpponent(),
      WeaponType.CORK_GUN => MakeCorkGunOpponent(),
      WeaponType.WATER_GUN => MakeWaterGunOpponent(),
    };
    c.pic = pic;
    c.lblTalk = lblTalk;
    c.ShowIdle();
    c.Shutup();
    return c;
  }
  private static Character MakeWaterGunOpponent() {
    Character c = new Character();
    c.Stats = new(luck: 0.7f, health: 100, reflex: 0.3f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_FireGoblin_Idle },
      {ImgState.NO_WEAPON, Resources.Img_FireGoblin_NoWeapon },
      {ImgState.READY, Resources.Img_FireGoblin_Ready },
      {ImgState.KILL, Resources.Img_FireGoblin_Kill },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("Why did I choose a water gun?", null) },
      {TalkState.SAY_OW, ("Ow", null) },
      {TalkState.BONED, ("So cold!", null) },
      {TalkState.GUN_WENT_OFF, ("Oh noes", null) },
      {TalkState.SURVIVED, ("My fire continues to roar!", null) },
    };
    return c;
  }
  private static Character MakeCorkGunOpponent() {
    Character c = new Character();
    c.Stats = new(luck: 0.0f, health: 100, reflex: 0.0f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_Shadow_Idle },
      {ImgState.NO_WEAPON, Resources.Img_Wizard_NoWeapon },
      {ImgState.READY, Resources.Img_Wizard_Ready },
      {ImgState.KILL, Resources.Img_Wizard_Kill },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("", null) },
      {TalkState.SAY_OW, ("", null) },
      {TalkState.BONED, ("", null) },
      {TalkState.GUN_WENT_OFF, ("", null) },
      {TalkState.SURVIVED, ("", null) },
    };
    return c;
  }
  private static Character MakeBowOpponent() {
    Character c = new Character();
    c.Stats = new(luck: 0.0f, health: 100, reflex: 0.0f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_Yoshi_Idle },
      {ImgState.NO_WEAPON, Resources.Img_Wizard_NoWeapon },
      {ImgState.READY, Resources.Img_Wizard_Ready },
      {ImgState.KILL, Resources.Img_Wizard_Kill },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("", null) },
      {TalkState.SAY_OW, ("", null) },
      {TalkState.BONED, ("", null) },
      {TalkState.GUN_WENT_OFF, ("", null) },
      {TalkState.SURVIVED, ("", null) },
    };
    return c;
  }
  private static Character MakeNerfRevolverOpponent() {
    Character c = new Character();
    c.Stats = new(luck: 0.0f, health: 100, reflex: 0.0f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_Shadow_Idle },
      {ImgState.NO_WEAPON, Resources.Img_Wizard_NoWeapon },
      {ImgState.READY, Resources.Img_Wizard_Ready },
      {ImgState.KILL, Resources.Img_Wizard_Kill },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("", null) },
      {TalkState.SAY_OW, ("", null) },
      {TalkState.BONED, ("", null) },
      {TalkState.GUN_WENT_OFF, ("", null) },
      {TalkState.SURVIVED, ("", null) },
    };
    return c;
  }
  private static Character MakeMagicWandOpponent() {
    Character c = new Character();
    c.Stats = new(luck: 0.4f, health: 100, reflex: 0.5f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_Wizard_Idle },
      {ImgState.NO_WEAPON, Resources.Img_Wizard_NoWeapon },
      {ImgState.READY, Resources.Img_Wizard_Ready },
      {ImgState.KILL, Resources.Img_Wizard_Kill },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("I will outlast you!", null) },
      {TalkState.SAY_OW, ("This hurts more than I thought!", null) },
      {TalkState.BONED, ("That didn't go as planned", null) },
      {TalkState.GUN_WENT_OFF, ("Well, that sucks!", null) },
      {TalkState.SURVIVED, ("I knew I would live!", null) },
    };
    return c;
  }

  public static Character MakePlayer(WeaponType weaponType, PictureBox pic, Label lblTalk) {
    Character c = weaponType switch {
      WeaponType.MAGIC_WAND => MakeMagicWandPlayer(),
      WeaponType.NERF_REVOLVER => MakeNerfRevolverPlayer(),
      WeaponType.BOW => MakeBowPlayer(),
      WeaponType.CORK_GUN => MakeCorkGunPlayer(),
      WeaponType.WATER_GUN => MakeWaterGunPlayer(),
    };
    c.pic = pic;
    c.lblTalk = lblTalk;
    c.ShowIdle();
    c.Shutup();
    return c;
  }
  private static Character MakeMagicWandPlayer() {
    Character c = new Character();
    c.Stats = new(luck: 0.5f, health: 100, reflex: 0.3f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_Bender_Idle },
      {ImgState.NO_WEAPON, Resources.Img_Bender_Idle },
      {ImgState.READY, Resources.Img_Bender_Ready_MagicWand },
      {ImgState.KILL, Resources.Img_Bender_Kill_MagicWand },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("Bite my shiny metal ass!", Resources.Snd_Bender_BiteMyShinyMetalAss) },
      {TalkState.SAY_OW, ("Ow ow ow!!!", null) },
      {TalkState.BONED, ("Oh, I'm boned!", Resources.Snd_Bender_ImBoned) },
      {TalkState.GUN_WENT_OFF, ("Oh My God!", Resources.Snd_Bender_OhMyGod) },
      {TalkState.SURVIVED, ("Hahahaha!", Resources.Snd_Bender_Laugh) },
    };
    return c;
  }
  private static Character MakeNerfRevolverPlayer() {
    Character c = new Character();
    c.Stats = new(luck: 0.5f, health: 100, reflex: 0.3f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_Bender_Idle },
      {ImgState.NO_WEAPON, Resources.Img_Bender_Idle },
      {ImgState.READY, Resources.Img_Bender_Idle },
      {ImgState.KILL, Resources.Img_Bender_Idle },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("Bite my shiny metal ass!", Resources.Snd_Bender_BiteMyShinyMetalAss) },
      {TalkState.SAY_OW, ("Ow ow ow!!!", null) },
      {TalkState.BONED, ("Oh, I'm boned!", Resources.Snd_Bender_ImBoned) },
      {TalkState.GUN_WENT_OFF, ("Oh My God!", Resources.Snd_Bender_OhMyGod) },
      {TalkState.SURVIVED, ("Hahahaha!", Resources.Snd_Bender_Laugh) },
    };
    return c;
  }
  private static Character MakeBowPlayer() {
    Character c = new Character();
    c.Stats = new(luck: 0.5f, health: 100, reflex: 0.3f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_Bender_Idle },
      {ImgState.NO_WEAPON, Resources.Img_Bender_Idle },
      {ImgState.READY, Resources.Img_Bender_Idle },
      {ImgState.KILL, Resources.Img_Bender_Idle },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("Bite my shiny metal ass!", Resources.Snd_Bender_BiteMyShinyMetalAss) },
      {TalkState.SAY_OW, ("Ow ow ow!!!", null) },
      {TalkState.BONED, ("Oh, I'm boned!", Resources.Snd_Bender_ImBoned) },
      {TalkState.GUN_WENT_OFF, ("Oh My God!", Resources.Snd_Bender_OhMyGod) },
      {TalkState.SURVIVED, ("Hahahaha!", Resources.Snd_Bender_Laugh) },
    };
    return c;
  }
  private static Character MakeCorkGunPlayer() {
    Character c = new Character();
    c.Stats = new(luck: 0.5f, health: 100, reflex: 0.3f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_Bender_Idle },
      {ImgState.NO_WEAPON, Resources.Img_Bender_Idle },
      {ImgState.READY, Resources.Img_Bender_Idle },
      {ImgState.KILL, Resources.Img_Bender_Idle },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("Bite my shiny metal ass!", Resources.Snd_Bender_BiteMyShinyMetalAss) },
      {TalkState.SAY_OW, ("Ow ow ow!!!", null) },
      {TalkState.BONED, ("Oh, I'm boned!", Resources.Snd_Bender_ImBoned) },
      {TalkState.GUN_WENT_OFF, ("Oh My God!", Resources.Snd_Bender_OhMyGod) },
      {TalkState.SURVIVED, ("Hahahaha!", Resources.Snd_Bender_Laugh) },
    };
    return c;
  }
  private static Character MakeWaterGunPlayer() {
    Character c = new Character();
    c.Stats = new(luck: 0.5f, health: 100, reflex: 0.3f);
    c.imgMap = new() {
      {ImgState.IDLE, Resources.Img_Bender_Idle },
      {ImgState.NO_WEAPON, Resources.Img_Bender_Idle },
      {ImgState.READY, Resources.Img_Bender_Ready_WaterGun },
      {ImgState.KILL, Resources.Img_Bender_Kill_WaterGun },
    };
    c.dialogMap = new() {
      {TalkState.TALK_SMACK, ("You look thirsty. Want some water?", null) },
      {TalkState.SAY_OW, ("It's freezing!", null) },
      {TalkState.BONED, ("Oh, I'm boned!", Resources.Snd_Bender_ImBoned) },
      {TalkState.GUN_WENT_OFF, ("This might not be so bad", null) },
      {TalkState.SURVIVED, ("Hahahaha!", Resources.Snd_Bender_Laugh) },
    };
    return c;
  }

  public void SaySmack() => Say(dialogMap[TalkState.TALK_SMACK]);
  public void SayOw() => Say(dialogMap[TalkState.SAY_OW]);
  public void SayBoned() => Say(dialogMap[TalkState.BONED]);
  public void SayGunWentOff() => Say(dialogMap[TalkState.GUN_WENT_OFF]);
  public void SaySurvived() => Say(dialogMap[TalkState.SURVIVED]);
  private void Say(string dialog) {
    Say((dialog, null));
  }
  private void Say((string dialog, UnmanagedMemoryStream audio) msg) {
    lblTalk.Text = msg.dialog;
    lblTalk.Visible = true;
    if (msg.audio is not null) {
      SoundManager.Play(msg.audio);
    }
  }

  public void Shutup() {
    lblTalk.Text = "";
    lblTalk.Visible = false;
  }

  public void ShowIdle() => Show(imgMap[ImgState.IDLE]);
  public void ShowNoWeapon() => Show(imgMap[ImgState.NO_WEAPON]);
  public void ShowReady() => Show(imgMap[ImgState.READY]);
  public void ShowKill() => Show(imgMap[ImgState.KILL]);
  private void Show(Bitmap img) {
    pic.Image = img;
  }

  public bool PullTrigger(Weapon weapon) {
    var result = weapon.PullTrigger(this);
    //Say(result.ToString());
    switch (result) {
      case PullTriggerResult.GOT_SHOT:
        ShowKill();
        SayGunWentOff();
        return true;
      case PullTriggerResult.MISFIRE:
      case PullTriggerResult.WENT_OFF_BUT_DODGED:
      case PullTriggerResult.DIDNT_GO_OFF:
        ShowNoWeapon();
        SaySurvived();
        return false;
    }
    return false;
  }
}
