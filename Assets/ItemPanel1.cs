using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemPanel1 : MonoBehaviour
{
    public static ItemPanel1 instance;

    [SerializeField] private TextMeshProUGUI textI;

    private void Awake()
    {
        instance = this;
    }

    public void getRes(string text)
    {
        textI.text = text;
    }
}
