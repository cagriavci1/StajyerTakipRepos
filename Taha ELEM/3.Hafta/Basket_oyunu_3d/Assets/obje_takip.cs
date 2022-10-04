using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obje_takip : MonoBehaviour
{
    public Transform top_takip;
    public Transform kamera;
    public Vector3 Ofset;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(top_takip.position);
        //transform.position = top_takip.position;
        kamera.position = top_takip.position+new Vector3(-5,1,-1/2);

    }
}
