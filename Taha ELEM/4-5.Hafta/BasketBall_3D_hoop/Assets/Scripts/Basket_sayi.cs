using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket_sayi : MonoBehaviour
{
    public Text basarili;
    public Text basarisiz;
    public int point = 0;
    public int escape = 0;
    public Oyuncu oyuncu;
    private bool topututma=false;
    public int sayac=0;
    public Transform top_pozisyon;
    public AudioSource basket_sesi;
    public AudioSource alkis_sesi;
    public AudioSource yuh_sesi;



    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    private void OnTriggerEnter(Collider col)
    {
        sayac++;
        if (sayac==1)
        {
            if (!topututma && col.gameObject.tag == "ring")//potaya deðdiðinde basket controlü
            {
                if (top_pozisyon.position.z<4.78f)
                {
                    point+=3;
                    basarili.text = "Point : " + point.ToString();

                }
                else if(top_pozisyon.position.z >= 4.78f)
                {
                    point+=2;
                    basarili.text = "Point : " + point.ToString();
                }

                basket_ses();
                Invoke("alkis_ses", 0.5f);
                //topututma = true;//topu attýðýnda
            }


            else  if (!topututma && col.gameObject.tag == "zemin")//topu tutmayý býraktýðýnda
            {
                escape++;
                basarisiz.text = "Escape : " + escape.ToString();
                Invoke("yuh_ses", 0.5f);

                // topututma = true;
            }
        }
        


        




    }

    #region ses
    void basket_ses() {

        basket_sesi.Play();
       
    }
    void alkis_ses()
    {

        alkis_sesi.Play();
    }
    void yuh_ses()
    {

        yuh_sesi.Play();
    }
    #endregion ses

    // Update is called once per frame
    void Update()
    {
         topututma = oyuncu.topu_tutma;
	
        

    }
}
