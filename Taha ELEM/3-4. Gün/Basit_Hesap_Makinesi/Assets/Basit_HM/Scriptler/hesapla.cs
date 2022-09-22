using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class hesapla : MonoBehaviour
{
    #region fields
    public TextMeshProUGUI txt_giris;
    private float sonuc;// Sonuç deðiþkeni textmesh için
    private float giris;
    private float giris2;
    private string islemler;

    #endregion fields

    #region methotlar
    void Start()
    {
        
    }

    public void numara_tikla(int deger)
    {

        
        Debug.Log(message: $"numara_tikla Deger :  {deger}");
       

        if (string.IsNullOrEmpty(txt_giris.text) )//true
        {
            txt_giris.text = Convert.ToString(deger);

            if (giris==0 && string.IsNullOrEmpty(islemler))
            {
                giris = Convert.ToInt32(txt_giris.text);
            }

            else if (giris !=0 && !string.IsNullOrEmpty(islemler))
            {
                giris2 = Convert.ToInt32(txt_giris.text);
            }
        }
        else
        {
            txt_giris.text += Convert.ToString(deger);

            if ( string.IsNullOrEmpty(islemler))
            {
                giris = Convert.ToInt32(txt_giris.text);
            }

            else if ( !string.IsNullOrEmpty(islemler))
            {
                giris2 = Convert.ToInt32(txt_giris.text);
            }
            Debug.Log("giris= " + giris + "  giris 2 = " + giris2);
        }



    //    txt_giris.text = $"{deger}";
    //    if (giris==0)
    //    {
    //        giris = deger;
    //    }
    //    else
    //    {
    //        giris2 = deger;
    //    }
    }

    public void islem_tikla(string deger)
    {
        hesapla kontrol = new hesapla();
        Debug.Log(message: $"islem_tikla Deger :  {deger}");
        if (string.IsNullOrEmpty(islemler))
        {
            islemler = deger;
            txt_giris.text = "";
        }
        else
        {
            islemler = deger;

            esit_tikla("=");
               
            
        }

    }

   

    public void esit_tikla(string deger)
    {
        Debug.Log(message: $" esit_tikla Deger :  {deger}");
        if (giris!=0 && giris2!=0 && !string.IsNullOrEmpty(islemler))
        {
            switch (islemler)
            {
                case "+":
                    sonuc = giris + giris2;
                        break;
                case "-":
                    sonuc = giris - giris2;
                        break;

                case "*":
                    sonuc = giris * giris2;
                    break;
                case "/":
                    sonuc = giris / giris2;
                    break;
            }
            txt_giris.SetText(sonuc.ToString());
        }
    }

    public void sifirla_tikla(string deger)
    {
        Debug.Log(message: $"sifirla_tikla Deger :  {deger}");
        giris = 0;
        giris2 = 0;
        islemler = "";
        txt_giris.SetText("");
    }
    #endregion mothotlar

    #region olaylar

    #endregion olaylar

}
