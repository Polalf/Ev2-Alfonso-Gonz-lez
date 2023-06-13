using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnearIng : MonoBehaviour
{
    bool canSpawn;
    public GameObject servir;
    int nIng = 0;
    private void Start()
    {
        canSpawn = true;
    }

    private void Update()
    {
        if (nIng >= 7)
        {
           canSpawn= false;
        }
        else
        {
            canSpawn = true;
        }
    }

    public void Spawnear(GameObject ingrediente)
    {if(canSpawn)
        {
            
            Instantiate(ingrediente, transform.position, transform.rotation);
            servir.GetComponent<pedido>().sandwinch[nIng] = ingrediente.name;
            nIng++;
        }
        
    }
}
