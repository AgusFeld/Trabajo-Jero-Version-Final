using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    //public Speed script;

    public GameObject Cactus1;
    public GameObject Cactus2;
    public GameObject Cactus3;
    public GameObject Pajaro;
    public float speed = -0.1f;
    float contador;
    GameObject C;
    GameObject C1;
    GameObject C2;
    GameObject P;
    void Start()
    {
        int randomNumber  = UnityEngine.Random.Range(1, 3);
        int random2 = UnityEngine.Random.Range(25, 50);

        
        if (randomNumber == 1)
        {
            C = Instantiate(Cactus1, new Vector3(0, .5f, random2), new Quaternion(0, 0, 0, 0));
            C.GetComponent<Rigidbody>();
            
            Destroy(C, 15);
        }
        if (randomNumber == 2)
        {
            C1 = Instantiate(Cactus2, new Vector3(0, .5f, random2), new Quaternion(0, 0, 0, 0));
            C.GetComponent<Rigidbody>();
            
            Destroy(C1, 15);
        }
        if (randomNumber == 3)
        {
            C2 = Instantiate(Cactus3, new Vector3(0, .5f, random2), new Quaternion(0, 0, 0, 0));
            C.GetComponent<Rigidbody>();
            
            Destroy(C2, 15);
        }
    }

    void OnTriggerEnter()
    {
        contador++;
        
            if (contador % 2 == 0)
            {
                speed -= 0.03f;
            }
        
        

        int randomNumber = UnityEngine.Random.Range(1, 5);
        int random2 = UnityEngine.Random.Range(25, 50);


        if (randomNumber == 1)
        {
            C = Instantiate(Cactus1, new Vector3(0, .5f, random2), new Quaternion(0, 0, 0, 0));
            Destroy(C, 15);
        }
        if (randomNumber == 2)
        {
            C1 = Instantiate(Cactus2, new Vector3(0, .5f, random2), new Quaternion(0, 0, 0, 0));
            Destroy(C1, 15);
        }
        if (randomNumber == 3)
        {
            C2 = Instantiate(Cactus3, new Vector3(0, .5f, random2), new Quaternion(0, 0, 0, 0));
            Destroy(C2, 15);
        }
        if (randomNumber == 4)
        {
            P = Instantiate(Pajaro, new Vector3(0, 1.1f, random2), new Quaternion(0, 0, 0, 0));
            Destroy(P, 15);
        }

    }
    // Update is called once per frame
    void Update()
    {
        //script.speed = speed;
        //if (C) C.transform.position += new Vector3(0, 0, speed);
        //if (C1) C1.transform.position += new Vector3(0, 0, speed);
        //if (C2) C2.transform.position += new Vector3(0, 0, speed);
        //if (P) P.transform.position += new Vector3(0, 0, speed);
    }

    
}
