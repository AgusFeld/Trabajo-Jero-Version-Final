using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    int TiempoTotal = 60;

    private Reintentar tiempo;

    public Text TimerText;

    int Counter = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        TiempoTotal = tiempo.TiempoTotal;
        Counter = tiempo.Counter;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.FloorToInt(Time.time) > Counter + 1)
        {
            TiempoTotal--;
            Counter++;
            TimerText.text = TiempoTotal.ToString();
        }
        if (TiempoTotal <= 0) SceneManager.LoadScene("Ganaste");
    }

    public void ResetTimer()
    {
       
    }
}
