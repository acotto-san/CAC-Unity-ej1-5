using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField]
    private GameObject farMovingBackground;
    [SerializeField]
    private GameObject nearMovingBackground;


    void LateUpdate()
    {
        Vector3 cameraPos = gameObject.transform.position;
        farMovingBackground.transform.position = new Vector3(cameraPos.x, farMovingBackground.transform.position.y, farMovingBackground.transform.position.z);
        nearMovingBackground.transform.position = new Vector3(cameraPos.x, nearMovingBackground.transform.position.y, nearMovingBackground.transform.position.z);

    }

    public void UpdatePosition(Vector3 newCamPos)
    {
        transform.position = newCamPos;
    }


}
