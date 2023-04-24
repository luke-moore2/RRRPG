using System.Media;

namespace RRRPG {
  public static class SoundManager {
    private static readonly SoundPlayer sndPlayer;

    static SoundManager() {
      sndPlayer = new();
    }

    public static void Play(UnmanagedMemoryStream ms) {
      try {
        sndPlayer.Stream = ms;
        sndPlayer.Play();
      }
      catch {
        // couldn't play sound, oh well
      }
    }
  }
}
