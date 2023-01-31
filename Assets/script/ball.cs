using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{
    public float hiz;
    private Rigidbody rb;
    Vector3 kuvvet;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update() {
       
    }
    

    private void FixedUpdate() 
    {
        if(yonetici.oyunbasladi == true)
        {
            float yatay = Input.GetAxis("Horizontal");
            float dikey = Input.GetAxis("Vertical");
            kuvvet = new Vector3(yatay,0,dikey);
            rb.AddForce (kuvvet*hiz);
        }
        
        
    }
   
}
