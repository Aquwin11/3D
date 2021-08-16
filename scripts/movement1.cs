using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class movement1 : MonoBehaviour
{
    public Transform character; 
    public Rigidbody rb;
    public float Forwardforce = 500f;
    public float Sideforce = 50f;
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        character.rotation = Quaternion.identity;
        rb.AddForce(0, 0, Forwardforce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(Sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//VelocityChange ignore mass of the character and changes immediately
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//Time.deltaTime process each frame
        }
        if (Input.GetKey("w"))
        {
            transform.localScale = new Vector3(0.2f, 1.5f, 1f);
        }
        else if (Input.GetKey("s"))
        {
            transform.localScale = new Vector3(1f, 0.5f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
