using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top_kod : MonoBehaviour
{

    Rigidbody fizik;
    public float hiz=1;
     AudioSource top_sesi;
    //public AudioSource tezahurat_sesi;
    
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        top_sesi = GetComponent<AudioSource>();
        //tezahurat_sesi = GetComponent<AudioSource>();
    }


    private void FixedUpdate()
    {
        //float dikey = Input.GetAxisRaw("Vertical"); //klavye kontrolü
        //float yatay = Input.GetAxisRaw("Horizontal");

        float dikey = SimpleInput.GetAxisRaw("Vertical");
        float yatay = SimpleInput.GetAxisRaw("Horizontal");
        Vector3 vektor = new Vector3(dikey, 0, -yatay);
        fizik.AddForce(vektor * hiz);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="zemin_tag")
        {
            top_sesi.Play();
        }
        //if (collision.collider.tag == "pota_tag")
        //{
        //    tezahurat_sesi.Play();
        //}
    }


}
