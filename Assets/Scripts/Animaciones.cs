using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    Animator animator; //este script intenta modificar propiedades del controller
    Colisiones colisiones; //para saber si el GameObject esta grounded
    Mover mover; //para saber si se está moviendo o saltando

    void Awake()
    {
        animator = GetComponent<Animator>();
        colisiones = GetComponent<Colisiones>();
        mover = GetComponent<Mover>();
    }


    void LateUpdate()
    {
        animator.SetBool("Grounded", colisiones.Grounded());
        //la logica de velocityX se usa entre mayor o menor a 0.1 así que se usa abs para hacerlo absoluto
        // y no tener problemas cuando la velocidad es negativa al ir a la izq
        animator.SetFloat("VelocityX", Mathf.Abs(mover.rb2D.velocity.x));
        animator.SetBool("Jumping", mover.isJumping);
    }
}
