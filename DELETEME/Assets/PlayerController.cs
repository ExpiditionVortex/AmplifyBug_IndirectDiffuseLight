using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 moveDir = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            moveDir += Vector3.forward;
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("Move forward");
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDir -= Vector3.forward;
            //transform.Translate(-Vector3.forward * speed * Time.deltaTime);
            Debug.Log("Move backward");
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveDir -= Vector3.right;
            //transform.Translate(-Vector3.right * speed * Time.deltaTime);
            Debug.Log("Move left");
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir += Vector3.right;
            Debug.Log("Move right");
        }

        if (moveDir.magnitude > 1)
            moveDir = moveDir.normalized;

        transform.Translate(moveDir * speed * Time.deltaTime);
    }
}
