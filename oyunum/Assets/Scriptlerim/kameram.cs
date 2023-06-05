using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameram : MonoBehaviour
{
    public Transform topkonum;
    Vector3 fark;

    void Start()
    {
        fark = transform.position - topkonum.position;
    }

    
    void Update()
    {
        if(topumunhareketi.dusme==false) {
            transform.position = topkonum.position + fark;
        }
      
    }
}
