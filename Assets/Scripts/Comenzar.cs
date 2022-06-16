using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comenzar : MonoBehaviour
{
    public void OnClickEvent()
    {
        SceneManager.LoadScene("SampleScene");
        
    }


}
