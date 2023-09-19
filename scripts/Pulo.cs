using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Requisitamos o componente Rigidbody
[RequireComponent(typeof(Rigidbody))]
public class Pulo : MonoBehaviour
{
    //Vari�vel que controla a for�a do pulo
    public float jumpForce = 500.0f;

    //Vari�vel que controla a massa/peso
    public float mass = 1.0f;

    //Acessamos o componente Rigidbody atrav�s dessa vari�vel
    private Rigidbody rigidbody;


    //Vari�vel de controle que nos diz se o personagem est� ou n�o no ch�o
    private bool isGround = false;

    void Start()
    {
        //Assim que o script  � executado, obtemos o componente Rigidbody e atribuimos a nossa vari�vel
        rigidbody = GetComponent<Rigidbody>();

        //Definimos o valor da massa via script
        rigidbody.mass = mass;
    }


    void Update()
    {
        //Verificamos se o usu�rio N�O pressionou a tecla Space ou se n�o est� no ch�o
        if (!Input.GetKeyDown(KeyCode.Space) || !isGround)
            return;

        //Adicionamos uma for�a ao Rigidbody
        rigidbody.AddForce(
            Vector3.up * jumpForce, //Para fazer o personagem pular, ent�o multiplicamos (0, 1, 0) pelo valor do pulo
            ForceMode.Impulse // Ajustamos a for�a para o tipo Impulse
            );
    }

    //Verifica se o personagem tocou no ch�o
    void OnCollisionEnter(Collision collision)
    {
        isGround = true;
    }

    //Verifica se o personagem saiu do ch�o
    void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }
}
