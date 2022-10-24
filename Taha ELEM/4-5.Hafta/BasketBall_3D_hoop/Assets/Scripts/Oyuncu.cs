using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Oyuncu : MonoBehaviour
{

    public TouchController control;//dokunmatik nesne
    private float limitx, limity;
    private float xrot, yrot;
    public float sensivity=40;


    public GameObject top;
    
    public GameObject Oyuncu_Camera;
    public float top_uzakl�k = 2.25f;
    public float top_firlatma_gucu = 5f;
    public bool topu_tutma = true;

    //private void FixedUpdate()
    //{
        
    //}


    // Start is called before the first frame update
    public void Start()
    {
       top.GetComponent<Rigidbody>().useGravity = false;//topun yer�ekimini false yap
      
    }

    

    // Update is called once per frame
    public void Update()
    {
        limitx = control.sliderhorizontal * sensivity;
        limity = control.slidervertical * sensivity;
        xrot = Mathf.Clamp(value: limity, min: -98, max: 98);
        yrot = Mathf.Clamp(value: limitx, min: -98, max: 98);
        Oyuncu_Camera.transform.localRotation = Quaternion.Euler(xrot, yrot, 0);


        if (topu_tutma)//e�er topu tutmu�sa
        {
            topu_tut();

            if (Input.GetMouseButtonDown(0))//e�er mouse t�kland���nda
            {
                // topu_firlat();

                //top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzakl�k;//topu kameran�n �n�ne getir tutma efekti
                //topu_tutma = false;//topu b�rak
                //top.GetComponent<Rigidbody>().useGravity = true;//topun yer �ekimini aktif et
                //top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kameranan�n �n�ne f�rlat 5f g�c�nde



            }


        }

    }

    public void topu_tut() {
        top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzakl�k;//topu kameran�n �n�ne getir tutma efekti

          //top.transform.position = new Vector3(Oyuncu_Camera.transform.position.x, top.transform.position.y, Oyuncu_Camera.transform.position.z + 4.5f);//on press olay�na yaz
          //top.GetComponent<Rigidbody>().useGravity = false; //on press olay�na yaz

    }
    public void topu_firlat() {


        if (topu_tutma)//e�er topu tutmu�sa
        {
            topu_tut();
            top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzakl�k;//topu kameran�n �n�ne getir tutma efekti
            topu_tutma = false;//topu b�rak
            top.GetComponent<Rigidbody>().useGravity = true;//topun yer �ekimini aktif et
            top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kameranan�n �n�ne f�rlat 5f g�c�nde

            if (Input.GetMouseButtonDown(0))//e�er mouse t�kland���nda
            {


                top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzakl�k;//topu kameran�n �n�ne getir tutma efekti
                topu_tutma = false;//topu b�rak
                top.GetComponent<Rigidbody>().useGravity = true;//topun yer �ekimini aktif et
                top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kameranan�n �n�ne f�rlat 5f g�c�nde



            }


        }





        if (Input.GetMouseButtonDown(0))
        {
            ////top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzakl�k;//topu kameran�n �n�ne getir tutma efekti
            ////topu_tutma = false;//topu b�rak
            ////top.GetComponent<Rigidbody>().useGravity = true;//topun yer �ekimini aktif et
            ////top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kameranan�n �n�ne f�rlat 5f g�c�nde

            //#region deneme_onpress
            //top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzakl�k;//topu kameran�n �n�ne getir tutma efekti

            //if (Input.GetMouseButtonUp(0))
            //{
            //    top.transform.position = Oyuncu_Camera.transform.position + Oyuncu_Camera.transform.forward * top_uzakl�k;//topu kameran�n �n�ne getir tutma efekti
            //    topu_tutma = false;//topu b�rak
            //    top.GetComponent<Rigidbody>().useGravity = true;//topun yer �ekimini aktif et
            //    top.GetComponent<Rigidbody>().AddForce(Oyuncu_Camera.transform.forward * top_firlatma_gucu);//topu kameranan�n �n�ne f�rlat 5f g�c�nde

            //}

            //#endregion deneme_onpress

         
        }



    }

}
