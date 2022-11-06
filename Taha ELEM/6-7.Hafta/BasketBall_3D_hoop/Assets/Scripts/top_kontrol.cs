using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top_kontrol : MonoBehaviour
{
    private float movespeed = 6f;
    public Transform top;
    public Transform kamera;
    public Transform yer;
    public Transform yukari;
    public Transform hedef;
    public bool top_havada = false;
    public bool top_yerde = true;
    private float T = 0f;
    public int pos_x = 0, pos_z = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        
        
        
            kamera.position = new Vector3(top.position.x + pos_x, kamera.position.y, top.position.z + pos_z);
        
        
    }
    // Update is called once per frame
    void Update()
    {

       
        //transform.position += direction * movespeed * Time.deltaTime;

        if (top_yerde)
        {


            if (Input.GetKey(KeyCode.Space))// topu tutma ve fýrlatma diagonal
            {
                top.position = new Vector3(yer.position.x, yukari.position.y, yer.position.z);// topu tutma efekti
                top.LookAt(hedef.parent.position);
                top.GetComponent<Rigidbody>().velocity = Vector3.zero;// resetten sonraa topun dönmesini engelleme
                top.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;// resetten sonraa topun dönmesini engelleme
                //heedefe potaya bakma


            }
            else
            {
                
                Vector3 direction = new Vector3(SimpleInput.GetAxisRaw("Horizontal"), 0, SimpleInput.GetAxisRaw("Vertical"));
                topu_hizada_tut();
                top.position = yer.position + Vector3.up * 2 * Mathf.Abs(Mathf.Sin(Time.time * 3));//topu zýplatma
                yer.position += direction * movespeed * Time.deltaTime;//emptyobjenin konumunu deðiþtirme yön tuþlarý ile
            }
        }

        //topu fýrlatma

        if (Input.GetKey(KeyCode.Space))
        {
            top_yerde = false;
            top_havada = true;
            T = 0;
        }
        if (top_havada)
        {
            Vector3 a = new Vector3(yer.position.x, yukari.position.y, yer.position.z);
            Vector3 b = hedef.position;
            T += Time.deltaTime;
            float duration = 0.5f;
            float t01 = T / duration * 0.5f;

            Vector3 pos = Vector3.Lerp(a, b, t01);
            //hareket arc ile
            Vector3 arc = Vector3.up * 2 * Mathf.Sin(t01 * Mathf.PI);
            top.position = pos + arc;


            //topu hedefe fýrlattýðý anda
            if (t01 >= 1)
            {
                top_havada = false;
                top.GetComponent<Rigidbody>().isKinematic = false;

            }
        }


    }
    #region methodlar
    void topu_hizada_tut()
    {
        if (yer.position.z > 16)//topu sýnýrda tutuma
        {
            yer.position = new Vector3(yer.position.x, yer.position.y, 16);
        }
        else if (yer.position.z < -10)
        {
            yer.position = new Vector3(yer.position.x, yer.position.y, -10);
        }
        else if (yer.position.x > 9)
        {
            yer.position = new Vector3(9, yer.position.y, yer.position.z);
        }
        else if (yer.position.x < -9)
        {
            yer.position = new Vector3(-9, yer.position.y, yer.position.z);
        }

    }
    public void topu_tut()
    {
       

        
        top.position = new Vector3(yer.position.x, yukari.position.y, yer.position.z);// topu tutma efekti
        top.LookAt(hedef.parent.position);
        top.GetComponent<Rigidbody>().velocity = Vector3.zero;// resetten sonraa topun dönmesini engelleme
        top.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;// resetten sonraa topun dönmesini engelleme
                                                                     //heedefe potaya bakma
        top_yerde = false;
        top_havada = true;
        T = 0;
        

        
        }
    public void topu_firlat()
    {
        //if (top_havada)
        //{
        //    Vector3 a = new Vector3(yer.position.x, yukari.position.y, yer.position.z);
        //    Vector3 b = hedef.position;
        //    T += Time.deltaTime;
        //    float duration = 0.5f;
        //    float t01 = T / duration * 0.5f;

        //    Vector3 pos = Vector3.Lerp(a, b, t01);
        //    //hareket arc ile
        //    Vector3 arc = Vector3.up * 2 * Mathf.Sin(t01 * Mathf.PI);
        //    top.position = pos + arc;


        //    //topu hedefe fýrlattýðý anda
        //    if (t01 >= 1)
        //    {
        //        top_havada = false;
        //        top.GetComponent<Rigidbody>().isKinematic = false;

        //    }
        //}



    }
    #endregion methodlar

}
