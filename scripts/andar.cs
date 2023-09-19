using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.03f, 0f, 0f); 
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.03f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0f, -0.03f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0f, 0.03f);
            bool isLeftButtonDown = Input.GetMouseButtonDown(0);
            bool isRightButtonDown = Input.GetMouseButtonDown(1);
            bool ismiddleButtonDown = Input.GetMouseButtonDown(2);
            print(isLeftButtonDown);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 180f, 0f);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, 0f);
        }
    }
}
