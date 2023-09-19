using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimJogo : MonoBehaviour
{ 
    public string ProximaFase;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "protagonista")
        {
            SceneManager.LoadScene("fim");

        }
    }
}
