using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HesapMakinesi : MonoBehaviour
{
    public TextMeshProUGUI girisMetni;
 
    private int giris;
    private int giris2;
    private float sonuc;
    private string islemler;
 

    public void sayiTikla(string deger)
    {
        if (islemler == null)
        {
            string gecici = Convert.ToString(giris);
            gecici += deger;
            giris = Convert.ToInt32(gecici);
            girisMetni.text = $"{giris}";
        }
        else
        {
            string gecici = Convert.ToString(giris2);
            gecici += deger;
            giris2 = Convert.ToInt32(gecici);
            string gecici3 = girisMetni.text + deger;
            girisMetni.text = $"{gecici3}";
        }
        Debug.Log($" degeriGoster: {deger}");
        
    }
    public void isareteTikla(string deger)
    {
        Debug.Log($" isareteTikla: {deger}");
        islemler = deger;
        girisMetni.text = $"{giris+islemler}";
    }
    public void esiteTikla(string deger)
    {
        Debug.Log($" esiteTikla: {deger}");

        if (giris != 0 && giris2 != 0 && !string.IsNullOrEmpty(islemler))
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
                case "÷":
                    sonuc = (giris*1.0f) / giris2;
                    break;
            }
            girisMetni.SetText(sonuc.ToString());
            silGiris();
        }
    }
    public void sileTikla()
    {
        giris=0;
        giris2=0;
        islemler = null;
        girisMetni.ClearMesh();
    }
    public void silGiris(){
        giris = 0;
        giris2 = 0;
        islemler=null;
    }
    public void sorular(){
        SceneManager.LoadScene("SorularEkrani");
    }  
} 
