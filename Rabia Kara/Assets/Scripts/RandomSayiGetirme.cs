using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;




public class RandomSayiGetirme : MonoBehaviour
{
    int sayi1, sayi2,islem;
    public Text islem1;
    public Text islem2;
    int a, b;
    int toplam, cikar, carp, bol;
    public Text dortislem;
    string  sonuc;
     Text tahmin;
    int puan;
    public Text ToplamPuan;
    public Text InputField;


    
    System.Random rastgele = new System.Random();
    
     
        public void SoruUret()
        {

            sayi1 = rastgele.Next(1, 51);
            sayi2 = rastgele.Next(1, 51);
            islem = rastgele.Next(1, 5);

            islem1.text = sayi1.ToString();
            islem2.text = sayi2.ToString();

            a = Convert.ToInt32(islem1.text);
            b = Convert.ToInt32(islem2.text);


            if (islem == 1)
            {
                dortislem.text = "+";
                toplam = a + b;
                sonuc = toplam.ToString();

            }

            if (islem == 2)
            {
                dortislem.text = "-";
                cikar = a - b;
                sonuc = cikar.ToString();
            }

            if (islem == 3)
            {
                dortislem.text = "*";
                carp = a * b;
                sonuc = carp.ToString();
            }

            if (islem == 4)
            {
                dortislem.text = "/";
                bol = a / b;
                sonuc = bol.ToString();
            }

        
        }
       
          public void Yanitla()
        {

            if(sonuc == InputField.text)
            {
                puan = puan + 10;
                ToplamPuan.text = puan.ToString();

            SoruUret();

            }
            else
            {
                puan = puan - 5;
                ToplamPuan.text = puan.ToString();
            }

        
          }
    void Start()
    {
        SoruUret();
    }
 

   
       
    
}
   
