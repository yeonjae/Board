using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    int Speed = 16;
    int Speed1 = 30;
    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveObject();
    }
    void moveObject()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.left * Speed1 * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.right * Speed1 * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.down * Speed1 * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * Speed1 * Time.deltaTime);

    }
}
