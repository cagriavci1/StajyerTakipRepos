using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;





public class RandomSayiGetirme : MonoBehaviour
{
    int sayi;
    int sayi1;
    int islemler;
    public Text islem1;
    public Text islem2;
    int a, b;
    int addition, extraction, multiply, devide;
    public Text dortislem;
    string  sonuc;
     Text tahmin;
    int puan;
    public Text ToplamPuan;
    public Text InputField;
    public UnityEngine.UI.Button buton;
    

    System.Random rastgele = new System.Random();
    

    public void SoruUret()
    {
        int c = Convert.ToInt32(ToplamPuan.text);

        sayi = rastgele.Next(1, 51);
        sayi1 = rastgele.Next(1, 51);
        islemler = rastgele.Next(1, 5);

        islem1.text = sayi.ToString();
        islem2.text = sayi1.ToString();

        a = Convert.ToInt32(islem1.text);
        b = Convert.ToInt32(islem2.text);

     
            if (100 != c  )
            {


                if (islemler == 1)
                {
                
                    dortislem.text = "+";
                    addition = a + b;
                    sonuc = addition.ToString();

                }

                if (islemler == 2)
                {
                
                    dortislem.text = "-";
                    extraction = a - b;
                    sonuc = extraction.ToString();
                }

                if (islemler == 3)
                {
               
                    dortislem.text = "*";
                    multiply = a * b;
                    sonuc = multiply.ToString();
                }

                if (islemler == 4)
                {
                    dortislem.text = "/";
                    devide = a / b;
                    sonuc = devide.ToString();
                }

           
        }


            else
            {
                SceneManager.LoadScene(2);
            }

        


    }

    


    public void Yanitla()
        {

            if(sonuc == InputField.text)
            {
                puan = puan + 5;
                ToplamPuan.text = puan.ToString();

            SoruUret();

            }
            else
            {
                puan = puan - 5;
                ToplamPuan.text = puan.ToString();
            }

        
          }
       public void kazandin()
    {

    }
   
    void Start()
    {
        
        SoruUret();
       
    }
 

   
       
    
}
   
