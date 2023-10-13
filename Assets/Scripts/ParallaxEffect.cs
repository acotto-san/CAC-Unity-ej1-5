using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField]
    private float parallaxMultiplier;
    private Transform cameraTransform;
    private Vector3 previousCameraPosition;


    void Start()
    {
        cameraTransform = Camera.main.transform;
        previousCameraPosition = cameraTransform.position;
    }


    void LateUpdate()
    {
        //metodo que llama cada capa para moverse ligado a la cámara pero con
        //un parallaxMultiplier que le incrementa o reduce el moviento en comparación
        float deltaX = (cameraTransform.position.x - previousCameraPosition.x) * parallaxMultiplier;
        transform.Translate(new Vector3(deltaX, 0, 0));
        previousCameraPosition = cameraTransform.position;
    }
}
