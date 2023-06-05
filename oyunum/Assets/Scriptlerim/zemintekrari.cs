using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemintekrari : MonoBehaviour
{
    public GameObject zeminnn;



    void Start()
    {
        for(int i = 0; i < 15; i++)
        {
            zemin_olusturr();
        }
       
    }


    void Update()
    {

    }

    public void zemin_olusturr()
    {
        Vector3 yon;
        if (Random.Range(0, 2) == 0)
        {
            yon = Vector3.left;

        }
        else
        {
            yon = Vector3.forward;
        }

        zeminnn = Instantiate(zeminnn, zeminnn.transform.position + yon, zeminnn.transform.rotation);
    }

}
  
