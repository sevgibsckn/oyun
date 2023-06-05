using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class skor : MonoBehaviour
{
    public static int skorum;
    public Text skorText;

    void Start()
    {
      skorum=0;  
    }

   
    void Update()
    {
        skorText.text =skorum.ToString();
    }
}
