using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeMove : MonoBehaviour
{
    //cube speed
    float speed = 5.0f;  // 5 units a second
    float stepSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //GetAxis == floaty acceleratey
        //GetAxisRaw == not floaty acceleratey

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        gameObject.transform.Translate(Vector3.right * x * Time.deltaTime * speed);
        gameObject.transform.Translate(Vector3.forward * y * Time.deltaTime * speed);

        ////wasd
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    gameObject.transform.Translate(Vector3.forward * stepSpeed);
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    gameObject.transform.Translate(Vector3.left * stepSpeed);
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    gameObject.transform.Translate(Vector3.back * stepSpeed);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    gameObject.transform.Translate(Vector3.right * stepSpeed);
        //}


        //// ijkl
        //if (Input.GetKey(KeyCode.I))
        //{
        //    gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //}
        //        if (Input.GetKey(KeyCode.J))
        //{
        //    gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
        //}
        //        if (Input.GetKey(KeyCode.K))
        //{
        //    gameObject.transform.Translate(Vector3.back * Time.deltaTime * speed);
        //}
        //        if (Input.GetKey(KeyCode.L))
        //{
        //    gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        //}

        // translate = move

    }
}
