using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public Creator creatorScript;

    void Start()
    {
        creatorScript = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Creator>();

    }

    void Update()
    {
        transform.position += new Vector3(0, 0, creatorScript.speed);
    }

    
}
