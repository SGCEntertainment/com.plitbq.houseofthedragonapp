using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item1 : MonoBehaviour
{

    [SerializeField] private string textI;

    public void SetRes()
    {
        ItemPanel1.instance.getRes(textI);
    }
}
