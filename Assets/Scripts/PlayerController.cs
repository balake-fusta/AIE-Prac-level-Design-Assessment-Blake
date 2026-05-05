using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpforce = 300.0f;
    public float playerspeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
        //player movemment
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward * playerspeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (transform.forward * -playerspeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (transform.right * -playerspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (transform.right * playerspeed);
        }

        //jumping
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, jumpforce, 0.0f));
        }

        //crouching
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.localScale = transform.localScale / 2;
            playerspeed = playerspeed / 2;
           
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            transform.localScale = transform.localScale * 2;
            playerspeed = playerspeed * 2;
        }

        //sprinting
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerspeed = playerspeed * 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerspeed = playerspeed / 2;
        }
    }
}
