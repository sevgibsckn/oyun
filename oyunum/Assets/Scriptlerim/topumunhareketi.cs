using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topumunhareketi : MonoBehaviour
{
    Vector3 yon;
    public float hýz;
    public zemintekrari zemintekrariscript;
    public static bool dusme;

    public float hýzekle;

    
    void Start()
    {
        yon = Vector3.forward;
        dusme = false;
    }

    
    void Update()
    {
        if (transform.position.y<=0.5f) { 

            dusme=true;
        }



        if (dusme==true)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (yon.x == 0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.forward;
            }

            hýz= hýz + hýzekle*Time.deltaTime;

        }

    }
    

    private void FixedUpdate()
    {
        Vector3 hareket = yon * Time.deltaTime * hýz;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag== "zemin")
        {
            skor.skorum++;

            collision.gameObject.AddComponent<Rigidbody>();

            zemintekrariscript.zemin_olusturr();
            StartCoroutine(ZeminiSil(collision.gameObject));
        }
    }

    IEnumerator ZeminiSil(GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);
    }
}

