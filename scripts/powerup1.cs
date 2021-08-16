using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class powerup1 : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "powerup")
        {
            Debug.Log(collisionInfo.collider.tag);
        }
    }
}
