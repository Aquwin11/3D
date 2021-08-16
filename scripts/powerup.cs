using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class powerup : MonoBehaviour
{
    public BoxCollider bc;
    [SerializeField] private Renderer myObject;
   void OnTriggerEnter(Collider myTrigger)
    {
        if(myTrigger.CompareTag("Player"))
        {
           Buff();
        }
    }
   void Buff()
    {
        bc.enabled = false;
        myObject.material.color = Color.white;
        Destroy(gameObject);
    }
}
