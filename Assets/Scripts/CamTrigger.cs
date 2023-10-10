using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public Vector3 newCamPos;
    public Animator animator;
    CamController camControl;   
    // Start is called before the first frame update
    void Start()
    {
        camControl = Camera.main.GetComponent<CamController>();
        animator = Camera.main.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("CamPosition0", true);

        }
    }
}
