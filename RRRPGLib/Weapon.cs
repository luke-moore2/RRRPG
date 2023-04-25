namespace RRRPG;

public enum PullTriggerResult {
  UNKNOWN,
  GOT_SHOT,
  WENT_OFF_BUT_DODGED,
  MISFIRE,
  DIDNT_GO_OFF,
}

public class Weapon {
  public List<bool> Chambers { get; private init; }
  public int CurChamberIndex { get; private set; }
  public WeaponType Type { get; private init; }
  public float ChanceOfMisfire { get; private init; }
  public float Damage { get; private init; }
  public float Velocity { get; private init; }
  private Random rand;

  public Weapon(List<bool> chambers, WeaponType type, float chanceOfMisfire, float damage, float velocity) {
    Chambers = chambers;
    Type = type;
    ChanceOfMisfire = chanceOfMisfire;
    Damage = damage;
    Velocity = velocity;
    rand = new Random();
  }

  public void SpinChamber() {

  }

  public PullTriggerResult PullTrigger(Character character) {
    PullTriggerResult result = PullTriggerResult.UNKNOWN;

    float chance = RandNumber();
    if (chance < 1 - character.Stats.Luck) {
      chance = RandNumber();
      if (chance >= ChanceOfMisfire) {
        float chanceToDodge = Math.Max(0, character.Stats.Reflex - Velocity);
        chance = RandNumber();
        if (chance < chanceToDodge) {
          result = PullTriggerResult.WENT_OFF_BUT_DODGED;
        }
        else {
          result = PullTriggerResult.GOT_SHOT;
        }
      }
      else {
        result = PullTriggerResult.MISFIRE;
      }
    }
    else {
      result = PullTriggerResult.DIDNT_GO_OFF;
    }
    return result;
  }

  private float RandNumber() {
    return rand.NextSingle();
  }

  public static Weapon MakeWeapon(WeaponType type) {
    Weapon weapon = type switch {
      WeaponType.BOW => MakeBow(),
      WeaponType.WATER_GUN => MakeWaterGun(),
      WeaponType.CORK_GUN => MakeCorkGun(),
      WeaponType.NERF_REVOLVER => MakeNerfRev(),
      WeaponType.MAGIC_WAND => MakeMagicWand(),
      _ => null
    };
    return weapon;
  }

  private static Weapon MakeNerfRev() {
    return new Weapon(
      chambers: new List<bool>(6),
      type: WeaponType.NERF_REVOLVER,
      chanceOfMisfire: 0.3f,
      damage: 25,
      velocity: 0.4f);
  }
  private static Weapon MakeCorkGun() {
    return new Weapon(
      chambers: new List<bool>(4),
      type: WeaponType.CORK_GUN,
      chanceOfMisfire: 0.4f,
      damage: 40,
      velocity: 0.2f);
  }
  private static Weapon MakeWaterGun() {
    return new Weapon(
      chambers: new List<bool>(8),
      type: WeaponType.WATER_GUN,
      chanceOfMisfire: 0.1f,
      damage: 20,
      velocity: 0.5f);
  }
  private static Weapon MakeBow() {
    return new Weapon(
      chambers: new List<bool>(3),
      type: WeaponType.BOW,
      chanceOfMisfire: 0.2f,
      damage: 50,
      velocity: 0.7f);
  }
  private static Weapon MakeMagicWand() {
    return new Weapon(
      chambers: new List<bool>(5),
      type: WeaponType.MAGIC_WAND,
      chanceOfMisfire: 0.3f,
      damage: 100,
      velocity: 0.2f);
  }
}
