using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class troca_de_cena : MonoBehaviour
{
    public string ProximaFase;
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag=="protagonista")
        {
            SceneManager.LoadScene("fase2");

        }
    }
}
