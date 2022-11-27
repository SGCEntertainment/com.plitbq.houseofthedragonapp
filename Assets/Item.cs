using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] private Sprite spriteI;

    [SerializeField] private string textI;

    public void SetRes()
    {
        ItemPanel.instance.getRes(spriteI, textI);
    }
}
