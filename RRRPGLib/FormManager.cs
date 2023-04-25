using System.Windows.Forms;

namespace RRRPG;

public static class FormManager {
  public static List<Form> openForms;

  static FormManager() {
    openForms = new();
  }

  public static void CloseAll() {
    for (int i = 0; i < openForms.Count; i++) {
      openForms[i].Close();
    }
  }
}