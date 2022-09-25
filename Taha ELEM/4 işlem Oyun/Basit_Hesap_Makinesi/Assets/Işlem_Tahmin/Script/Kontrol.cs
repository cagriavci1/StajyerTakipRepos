using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Kontrol : MonoBehaviour
{
    private string[] islem= {"+","-","X", "�" };  //rastggele i�lem olu�turmak i�in kullan�lacak de�i�kenler
    private int islem_index,sayi_1, sayi_2; //rastggele i�lem olu�turmak i�in kullan�lacak de�i�kenler


    private int sonuc,sayi_tahmin,tahmin_sayisi;

    [SerializeField]
    private GameObject btn;
    [SerializeField]
    private Text yazi;//soru sorulacak text 
    [SerializeField]
    private Text ipucu;
    [SerializeField]
    private InputField input;
    private void Awake()
    {
        sonuc = Random.Range(0, 100);
        islem_olustur();
        
    }


    private void islem_olustur()// rasgele islem olu�turma 0-100 aras� say�larla 
    {
        islem_index = Random.Range(0, 4);
        sayi_1 = Random.Range(0, 100);
        sayi_2 = Random.Range(0, 100);
        yazi.text = sayi_1 + "   " + islem[islem_index] + "  " + sayi_2 + "  = ?";
        Debug.Log(yazi.text);

        if (islem[islem_index] == "+")
        {
            sonuc = sayi_1 + sayi_2;
        }
        else if (islem[islem_index] == "-")
        {
            sonuc = sayi_1 - sayi_2;
        }
        else if (islem[islem_index] == "X")
        {
            sonuc = sayi_1 * sayi_2;
        }
        else if (islem[islem_index] == "�")
        {
            sonuc = sayi_1 / sayi_2;
        }

    }


    public void oyuna_basla()
    {
        SceneManager.LoadScene(0);

    }

    public void input_getir() 
    {
        string tahmin;
        if (string.IsNullOrEmpty(input.text) || input.text == "")
        {
            tahmin = "0";
        }
        else {  tahmin = input.text; }
        
        tahmin_kasilastir(int.Parse(tahmin));

        input.text = "";//sonu�tan sonra texti siler
        
        tahmin_sayisi++;

    }
    void tahmin_kasilastir(int tahmin)
    {
        if (tahmin==sonuc)
        {
            ipucu.color = Color.green;
            ipucu.text = "Say�y� dogru tahmin ettin !! "+tahmin+ "   "+ tahmin_sayisi+". ad�mda tahmin edebildin. Tekrar oynamak ister misin?";
            btn.SetActive( true);//buttonu aktifle�tir.
        }
        else if (tahmin<sonuc)
        {
            ipucu.color = Color.red;
            ipucu.text = "Yanl�s Hesaplad�n Daha B�y�k Bir Sonuc Olmal� !!";

        }
        else if (tahmin>sonuc)
        {
            ipucu.color = Color.red;
            ipucu.text = "Yanl�s Hesaplad�n Daha Kucuk Bir Sonuc Olmal� !!";
        }
    }

    public void tekrar_oyna() 
    {
        islem_olustur();
        tahmin_sayisi = 0;
        ipucu.text = "";
        btn.SetActive(false);
    }


}
