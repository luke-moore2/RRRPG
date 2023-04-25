namespace RRRPG {
  public class Stats {
    public float Luck { get; set; }
    public int Health { get; set; }
    public float Reflex { get; set; }

    public Stats(float luck, int health, float reflex) {
      Luck = luck;
      Health = health;
      Reflex = reflex;
    }
  }
}
