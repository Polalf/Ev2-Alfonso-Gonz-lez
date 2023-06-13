using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{
    public bool canWait;
    float timer;
    public float tiempoEspera;

    private void Start()
    {
        timer = 0;
        canWait = false;
    }

    private void Update()
    {
        if(canWait)
        {
            if(timer >= tiempoEspera)
            {
                CargarIns(0);
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }

    public void CargarIns(int nScn)
    {
        SceneManager.LoadScene(nScn);
    }
    

    
}
