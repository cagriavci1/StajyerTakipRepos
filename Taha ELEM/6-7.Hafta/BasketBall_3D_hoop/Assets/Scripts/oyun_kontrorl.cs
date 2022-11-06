using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class oyun_kontrorl : MonoBehaviour
{
    
    public top_kontrol oyuncu;
    
    public float reset_zamanlama=10f;
    public GameObject kamera_reset;
    public GameObject yer_colider;
    public GameObject top_reset;
    public Basket_sayi sayi;
    public GameObject victory_pnl;
    public GameObject defeat_pnl;
    public AudioSource arka_fon;
    


    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (sayi.point >= 10)
        {
            victory_pnl.SetActive(true);
           
            arka_fon.Stop();
            
        }else if ( sayi.escape == 5)
        {
            defeat_pnl.SetActive(true);
           
            arka_fon.Stop();

        }
        if (!oyuncu.top_yerde == true)// yeterli sayý ve escape için yazýlan if
        {
           
            
           if(sayi.point<10 && sayi.escape<5) {
                // normal reset kodlarý
                reset_zamanlama -= Time.deltaTime;
                if (reset_zamanlama <= 0)
                {
                    Debug.Log("reset çalýþýyor");
                    // SceneManager.LoadScene(1);//oyunu yeniden baþlatýr. ilk sahneye geçiþide saðlanabilir

                    
                    kamera_reset.transform.position = new Vector3(0.109999999f, 10.2799997f, -26.1200008f);


                   
                    yer_colider.transform.position = new Vector3(0f, 0.430000007f, 0f); //top yer nesnesini takip ettiðinden top spawn için      kamera_reset.transform.position + kamera_reset.transform.forward * 2.25f;//topu kameranýn önüne getir tutma efekti
                    resetleme();



                }



            }
            
            
           
            }

  

    }

    #region kontrol_method
    public void resetleme()
    {

      
       
        top_reset.GetComponent<Rigidbody>().velocity = Vector3.zero;// resetten sonraa topun dönmesini engelleme
       top_reset.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;// resetten sonraa topun dönmesini engelleme

        top_reset.GetComponent<Rigidbody>().AddForce(0, 0, 0);//topa uygulanan gücü sýfýrla
        
        oyuncu.top_yerde = true;
        sayi.sayac = 0;

        reset_zamanlama = 5f;
        


        
        yer_colider.transform.position = new Vector3(0f, 0.430000007f, 0f);//topun spawný için yer colider sýfýrlama 
       
        Debug.Log("resetleme() çalýþtý");


    }

    public void oyunu_yeniden_baslat()
    {
        
        SceneManager.LoadScene(0);//oyunu yeniden baþlatýr. ilk sahneye geçiþide saðlanabilir

    }

    public void retry_games()
    {
        int Simdiki_level = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);

    }

    public  void next_level()
    {
        int Simdiki_level = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(Simdiki_level);//birden fazlaa level olunca  Simdiki_level+1 ekle
    }

    public void exit_games()
    {
        Application.Quit();//oyunu sonlandýrýr.

    }
    

    #endregion kontrol_method


}

