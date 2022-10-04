using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top_hareket : MonoBehaviour
{
    public Rigidbody rb;
    public float speed=1;
    float x,z;
    Vector3 move = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Vertical");
        z = Input.GetAxis("Horizontal");
        move = new Vector3(x, 0, -z) * Time.deltaTime * speed;
        rb.MovePosition(transform.position + transform.TransformDirection(move));

        //if (Input.GetKey(KeyCode.UpArrow))//ileri
        //{
        //    this.rb.AddForce(+1, 0, 0);
        //}
        //else if (Input.GetKey(KeyCode.DownArrow))//geri
        //{
        //    this.rb.AddForce(-1, 0, 0);
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    this.rb.AddForce(0, 0, +1);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.rb.AddForce(0, 0, -1);
        //}




    }
}
