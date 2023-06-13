using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pedido : MonoBehaviour
{
    [Header("Ingredientes")]
    public string[] orden;
    public string[] sandwinch;
    public TMP_Text[] textoIngredientes;
    
    public string [] ingredientesDisp;

    [Header("Puntaje")]
    public int puntaje;
    public TMP_Text textoPuntaje;
    public TMP_Text congrats;
    bool canPress;

    public GameObject barraTiempo;

    
    
    void Start()
    {
        canPress = true;
        CrearOrden();
    }

    
    public void Servir()
    {
        if(canPress)
        {
            barraTiempo.GetComponent<tiempoJuego>().canRun = false;
            for (int i = 0; i < orden.Length; i++)
            {
                if (orden[i] == sandwinch[i])
                {
                    puntaje += 100;
                    textoPuntaje.text = puntaje.ToString();
                }
            }

            if (puntaje >= 0 && puntaje <= 299)
            {
                congrats.text = "BAD";
                gameObject.GetComponent<cambioEscena>().canWait = true;
            }
            else if (puntaje >= 300 && puntaje <= 599)
            {
                congrats.text = "GOOD";
                gameObject.GetComponent<cambioEscena>().canWait = true;

            }
            else if (puntaje >= 600 && puntaje <= 700)
            {
                congrats.text = "VERY GOOD";
                gameObject.GetComponent<cambioEscena>().canWait = true;

            }
            else if (puntaje >= 701)
            {
                congrats.text = "Felicidades, encontraste una falla";
                gameObject.GetComponent<cambioEscena>().canWait = true;

            }

            canPress = false;
        }
        

    }
    public void CrearOrden()
    {
        orden[0] = ingredientesDisp[0];
        orden[6] = ingredientesDisp[0];
        for (int i = 1;  i < orden.Length - 1; i++)
        {
            orden[i] = ingredientesDisp[Random.Range(0, 5)] ;
            textoIngredientes[i].text = orden[i]; 
        }
    }
    
    
}
