using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reintentar : MonoBehaviour
{
    public int TiempoTotal;
    public int Counter;
    
    public void OnClickEvent()
    {
        SceneManager.LoadScene("Menu");
        
        TiempoTotal = 60;
        Counter = 0;
    }


}
