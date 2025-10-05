using UnityEngine;
using UnityEngine.UI;

public class TurnGreenOnCheck : MonoBehaviour
{
    [SerializeField] Color checkedColor;
    [SerializeField] Color uncheckedColor;

    [SerializeField] Image bg;
    Toggle toggle;
    private void Start() {
        toggle = GetComponent<Toggle>();
    }

    public void ChangeCheck() {

        if (toggle.isOn) {
            bg.color = checkedColor;
        } else bg.color = uncheckedColor;
    }
}
