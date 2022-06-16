using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    AudioSource fuenteAudio;
    public AudioClip saltoSound;
    private float jumpForce = 7.50f;
    private float descentForce = -9.5f;
    private bool salto;
    private bool bajar;
    //private float speed = 0.1f;

    private void Start()
    {
        salto = false;
        fuenteAudio = GetComponent<AudioSource>();
    }



    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        //transform.position += new Vector3(0, 0, speed);

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = Vector3.up * descentForce;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.position += new Vector3(0, 0.25f, 0);
        }

        if (salto)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = Vector3.up * jumpForce;
                salto = false;
                bajar = false;
                fuenteAudio.clip = saltoSound;
                fuenteAudio.Play();
            }
        }
        if (bajar)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.localScale = new Vector3(1, 0.5f, 1);
                transform.position = new Vector3(0, 0.25f, 0);
            }
        }
        
    }

    void OnCollisionEnter(Collision Collision)
    {

        Debug.Log("Collided");
        if (Collision.gameObject.name == "Cactus")
        {
            transform.position = new Vector3(0, 0.5f, 0);
        }
        if (Collision.gameObject.name == "ground")
        {
            salto = true;
            bajar = true;
        }
        if (Collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("Perdiste");
        }

    }
}