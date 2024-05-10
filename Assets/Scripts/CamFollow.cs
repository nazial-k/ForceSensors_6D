using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset = new Vector3(0f,0f,0f);

    //public Vector3 rotationOffset = new Vector3(10f,-25f,0f);

    void Update()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target.position);
        }
    }
}
