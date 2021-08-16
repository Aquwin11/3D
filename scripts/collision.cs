using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class collision : MonoBehaviour 
{
    public movement1 move;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "wall")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
