using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class oyun_kontrorl : MonoBehaviour
{
    
    public Oyuncu oyuncu;
    public TouchController control;
    public float reset_zamanlama=5f;
    public GameObject kamera_reset;
   // public GameObject oyuncu_reset;
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
            //Time.timeScale = 0.0f;
            //oyuncu.GetComponent<FirstPersonController>().enabled = false;
            arka_fon.Stop();
            
        }else if ( sayi.escape == 5)
        {
            defeat_pnl.SetActive(true);
           // Time.timeScale = 0.0f;
            //oyuncu.GetComponent<FirstPersonController>().enabled = false;
            arka_fon.Stop();

        }
        if (oyuncu.topu_tutma==false)// yeterli sayý ve escape için yazýlan if
        {
           
            
            {
                // normal reset kodlarý
                reset_zamanlama -= Time.deltaTime;
                if (reset_zamanlama <= 0)
                {
                    Debug.Log("toputuma true");
                    // SceneManager.LoadScene(1);//oyunu yeniden baþlatýr. ilk sahneye geçiþide saðlanabilir

                    resetleme();
                    kamera_reset.transform.position = new Vector3(0, 3.81f, -4.9f);


                    // oyuncu_reset.transform.position= new Vector3(0, 0.8f, 0);
                    // top_reset.transform.position = new Vector3(0, 3.81f, -4.9f);
                    top_reset.transform.position = new Vector3(0, 3.81f, -4.9f); //kamera_reset.transform.position + kamera_reset.transform.forward * 2.25f;//topu kameranýn önüne getir tutma efekti




                }



            }
            
            
           
            }

  

    }

    #region kontrol_method
    public void resetleme()
    {

        //friction 0.6 - 0.75
        oyuncu.top.GetComponent<Rigidbody>().useGravity = false;//yerçekimini sýfýrla false olmalý
        top_reset.GetComponent<Rigidbody>().velocity = Vector3.zero;// resetten sonraa topun dönmesini engelleme
        top_reset.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;// resetten sonraa topun dönmesini engelleme

        top_reset.GetComponent<Rigidbody>().AddForce(0, 0, 0);//topa uygulanan gücü sýfýrla
        control.kamera_rot_reset();
        oyuncu.topu_tutma = true;
        sayi.sayac = 0;

        reset_zamanlama = 5f;



    }

    public void oyunu_yeniden_baslat()
    {
        
        SceneManager.LoadScene(1);//oyunu yeniden baþlatýr. ilk sahneye geçiþide saðlanabilir

    }

    public void retry_games()
    {
        int Simdiki_level = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1);

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

