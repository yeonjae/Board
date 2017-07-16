using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float m_speed = 0.05f;
    Camera mycam;

    // Use this for initialization
    void Start()
    {
        mycam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //Optional : for using Multi Plafform
        //mycam.orthographicSize = (Screen.height / 25f) / 2f;

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, m_speed) + new Vector3(-1, 0, -1);
        }
    }
}
