using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Rigidbody rb;
    public float force = 4.0f;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.005f)
           
                rb.AddForce(0, force*1.5f, 0, ForceMode.Impulse);
         
        }
        
    }

    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal") * force,
                               0,
                               Input.GetAxis("Vertical") * force);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            if (score < 2)
                Destroy(gameObject);
            else
                collision.collider.enabled = false;
            
        }
           
        
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject);
            score++;
  
        }
    }
}
