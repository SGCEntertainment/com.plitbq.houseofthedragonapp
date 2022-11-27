using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemPanel : MonoBehaviour
{
    public static ItemPanel instance;

    [SerializeField] private Image spriteI;

    [SerializeField] private TextMeshProUGUI textI;

    private void Awake()
    {
        instance = this;
    }

    public void getRes(Sprite sprite, string text)
    {
        spriteI.sprite = sprite;
        textI.text = text;
    }
}
