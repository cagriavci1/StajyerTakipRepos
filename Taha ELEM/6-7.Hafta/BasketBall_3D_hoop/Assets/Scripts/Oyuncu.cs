using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Oyuncu : MonoBehaviour
{
   

    public GameObject top;
    
    public GameObject Oyuncu_Camera;
    public float top_uzaklýk = 2.25f;
    public float top_firlatma_gucu = 5f;
    public bool topu_tutma = true;

    //private void FixedUpdate()
    //{
        
    //}


    // Start is called before the first frame update
    public void Start()
    {
       top.GetComponent<Rigidbody>().useGravity = false;//topun yerçekimini false yap

        //FPS CAMERA ÝÇÝN
       // kamera = Camera.main.transform;

    }



    // Update is called once per frame
    public void Update()
    {
        #region fps_dokunmatik
       // bak();
        #endregion fps_dokunmatik


   

        if (topu_tutma)//eðer topu tutmuþsa
        {
           topu_tut(); 

            if (Input.GetMouseButtonDown(0))//eðer mouse týklandýðýnda
            {
                // topu_firlat();

                //top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzaklýk;//topu kameranýn önüne getir tutma efekti
                //topu_tutma = false;//topu býrak
                //top.GetComponent<Rigidbody>().useGravity = true;//topun yer çekimini aktif et
                //top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kamerananýn önüne fýrlat 5f gücünde



            }


        }

    }



    #region methodlar

    public void topu_tut() {
        top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzaklýk;//topu kameranýn önüne getir tutma efekti

          //top.transform.position = new Vector3(Oyuncu_Camera.transform.position.x, top.transform.position.y, Oyuncu_Camera.transform.position.z + 4.5f);//on press olayýna yaz
          //top.GetComponent<Rigidbody>().useGravity = false; //on press olayýna yaz

    }
    public void topu_firlat() {


        if (topu_tutma)//eðer topu tutmuþsa
        {
            topu_tut();
            top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzaklýk;//topu kameranýn önüne getir tutma efekti
            topu_tutma = false;//topu býrak
            top.GetComponent<Rigidbody>().useGravity = true;//topun yer çekimini aktif et
            top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kamerananýn önüne fýrlat 5f gücünde

            if (Input.GetMouseButtonDown(0))//eðer mouse týklandýðýnda
            {


                top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzaklýk;//topu kameranýn önüne getir tutma efekti
                topu_tutma = false;//topu býrak
                top.GetComponent<Rigidbody>().useGravity = true;//topun yer çekimini aktif et
                top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kamerananýn önüne fýrlat 5f gücünde



            }


        }





        if (Input.GetMouseButtonDown(0))
        {
            ////top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzaklýk;//topu kameranýn önüne getir tutma efekti
            ////topu_tutma = false;//topu býrak
            ////top.GetComponent<Rigidbody>().useGravity = true;//topun yer çekimini aktif et
            ////top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kamerananýn önüne fýrlat 5f gücünde

            //#region deneme_onpress
            //top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzaklýk;//topu kameranýn önüne getir tutma efekti

            //if (Input.GetMouseButtonUp(0))
            //{
            //    top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzaklýk;//topu kameranýn önüne getir tutma efekti
            //    topu_tutma = false;//topu býrak
            //    top.GetComponent<Rigidbody>().useGravity = true;//topun yer çekimini aktif et
            //    top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kamerananýn önüne fýrlat 5f gücünde

            //}

            //#endregion deneme_onpress

         
        }



    }
    #endregion methodlar

}
