using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodar : MonoBehaviour
{
    public float vel = 10000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.Translate(Vector3.forward * vel * Time.deltaTime);
    }
}
