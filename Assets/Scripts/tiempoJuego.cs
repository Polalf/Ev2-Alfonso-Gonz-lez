using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tiempoJuego : MonoBehaviour
{
    public Slider temporizador;
    public float tiempo;
    float timer;
    public TMP_Text congrats;
    public bool canRun;

    private void Start()
    {
        canRun = true;
        temporizador.maxValue = tiempo;
        timer = tiempo;
    }
    void Update()
    {
        if(canRun)
        {
            if (timer <= 0)
            {
                congrats.text = "TIME’S UP";
                gameObject.GetComponent<cambioEscena>().canWait = true;
            }
            else
            {
                timer -= Time.deltaTime;
            }
            temporizador.value = timer;
        }
        
    }

}
