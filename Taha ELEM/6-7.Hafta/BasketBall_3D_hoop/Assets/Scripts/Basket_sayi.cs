using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket_sayi : MonoBehaviour
{
    public Text basarili;
    public Text basarisiz;
    public int point = 0;
    int sayi = 0;
    public int escape = 0;
    public top_kontrol oyuncu;
    private bool topututma=false;
    public int sayac=0;
    public Transform top_pozisyon;//yewr nesnesi ile kontrol sağlandı
    public AudioSource basket_sesi;
    public AudioSource alkis_sesi;
    public AudioSource yuh_sesi;
    public AudioSource top_zmn_sesi;

   
    #region anime
    public Animator kadin_anim;
    public Animator erkek_anim;
    public Animator kadin_anim1;
    public Animator erkek_anim1;
    public Animator kadin_anim2;
    public Animator erkek_anim2;
    public Animator kadin_anim3;
    public Animator erkek_anim3;
    public Animator kadin_anim4;
    public Animator erkek_anim4;
    public Animator kadin_anim5;
    public Animator erkek_anim5;
    public Animator kadin_anim6;
    public Animator erkek_anim6;
    public Animator kadin_anim7;
    public Animator erkek_anim7;
    public Animator kadin_anim8;
    public Animator erkek_anim8;
    public Animator kadin_anim9;
    public Animator erkek_anim9;
    public Animator kadin_anim10;
    public Animator erkek_anim10;
    public Animator kadin_anim11;
    public Animator erkek_anim11;
    #endregion anime




    // Start is called before the first frame update
    void Start()
    {
       
       

        
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "sayi2")
        {
            sayi = 2;
        }
        else if (col.gameObject.tag == "sayi3")
        {
            sayi = 3;
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        sayac++;
        if (sayac>1)
        {
           
            Debug.Log("çarğışma çalışıyor");
            if (topututma && col.gameObject.tag == "ring")//potaya değdiğinde basket controlü
            {
                if (top_pozisyon.position.z<6f)
                {
                    point+=sayi;
                    basarili.text = "Point : " + point.ToString();

                }
                else if(top_pozisyon.position.z >= 6f && top_pozisyon.position.x>=-7 && top_pozisyon.position.x <= 7)//col.gameObject.tag == "sayi2" top_pozisyon.position.z >= 6f
                {
                   point+=sayi;
                    basarili.text = "Point : " + point.ToString();
                }
                else
                {
                    point += sayi;
                    basarili.text = "Point : " + point.ToString();
                }

                basket_ses();
                Invoke("alkis_ses", 0.0f);
                anm_alkis();//animasyon
                Invoke("anm_kafasallama", 4.0f);
                //topututma = true;//topu attığında
                sayi = 0;
            }


            else  if (topututma && col.gameObject.tag == "zemin")//topu tutmayı bıraktığında
            {
                escape++;
                basarisiz.text = "Escape : " + escape.ToString();
                Invoke("yuh_ses", 0.0f);

                anm_kaybetme();
                Invoke("anm_kafasallama",4.0f);
               
                // topututma = true;
            }
        }
        


        




    }

   

    #region carpisma_kontrol
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "zemin")
        {
            top_sesi();
        }
       
        
    }
    #endregion carpisma_kontrol

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
    void top_sesi() 
    {
        top_zmn_sesi.Play();
    }
    #endregion ses

    #region animasyon

    void anm_kafasallama() 
    {
        kadin_anim.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim.SetInteger("erkek_kafa_gecis", 0);
        erkek_anim1.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim1.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim2.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim2.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim3.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim3.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim4.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim4.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim5.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim5.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim6.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim6.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim7.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim7.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim8.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim8.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim9.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim9.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim10.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim10.SetInteger("kadin_kafa_gecis", 0);//kafasallama
        erkek_anim11.SetInteger("erkek_kafa_gecis", 0);
        kadin_anim11.SetInteger("kadin_kafa_gecis", 0);//kafasallama

    }
    void anm_alkis()//alkış
    {
        kadin_anim.SetInteger("kadin_kafa_gecis", 1);//alkış
        erkek_anim.SetInteger("erkek_kafa_gecis", 1);
        erkek_anim1.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim1.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim2.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim2.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim3.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim3.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim4.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim4.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim5.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim5.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim6.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim6.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim7.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim7.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim8.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim8.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim9.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim9.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim10.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim10.SetInteger("kadin_kafa_gecis", 1);
        erkek_anim11.SetInteger("erkek_kafa_gecis", 1);
        kadin_anim11.SetInteger("kadin_kafa_gecis", 1);
    }
    void anm_kaybetme()
    {
        kadin_anim.SetInteger("kadin_kafa_gecis", 2);//kafa sallama
        erkek_anim.SetInteger("erkek_kafa_gecis", 2);
        erkek_anim1.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim1.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim2.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim2.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim3.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim3.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim4.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim4.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim5.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim5.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim6.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim6.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim7.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim7.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim8.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim8.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim9.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim9.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim10.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim10.SetInteger("kadin_kafa_gecis", 2);
        erkek_anim11.SetInteger("erkek_kafa_gecis", 2);
        kadin_anim11.SetInteger("kadin_kafa_gecis", 2);
    }

    #endregion animasyon

    // Update is called once per frame
    void Update()
    {
         topututma = oyuncu.top_havada;
	
        

    }
}
