using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoodleRight_Movement : MonoBehaviour
{
    public enum Hand { Right, Left }
    public Hand currentHand;
    Rigidbody2D rbody;
    public float speed = 1f;

    static float handSpeed;

    private string horizontal;
    private string vertical;

    // Use this for initialization
    void Start()
    {
        currentHand = Hand.Right;
        rbody = GetComponent<Rigidbody2D>();
        switch (currentHand){
            case Hand.Left:
                horizontal = "Horizontal1";
                vertical = "Vertical1";
                break;
            case Hand.Right:
                horizontal = "Horizontal2";
                vertical = "Vertical2";
                break;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        handSpeed = speed;
        //if (Input.GetKey(KeyCode.RightArrow))
        //    //transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        //     rbody.MovePosition(rbody.position + new Vector2(speed * Time.deltaTime, 0));
        // if (Input.GetKey(KeyCode.LeftArrow))
        // transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

        //if (Input.GetKey(KeyCode.UpArrow))
        // transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);

        //if (Input.GetKey(KeyCode.DownArrow))
        //transform.position -= new Vector3( 0.0f, speed * Time.deltaTime, 0.0f);

        rbody.velocity = new Vector3(Input.GetAxis(horizontal), Input.GetAxis(vertical)) * handSpeed;
    }

}