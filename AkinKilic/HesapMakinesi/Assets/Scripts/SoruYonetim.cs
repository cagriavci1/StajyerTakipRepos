using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoruYonetim : MonoBehaviour
{
    public List<SoruVeCevaplar> soruVeCevaplar;
    public GameObject[] secenekler;
    public int mevcutSoru;

    public GameObject soruPanel;
    public GameObject oyunBittiPanel;
    public GameObject sonrakiSoruPanel;

    public Button cevapBtn1;


    public Text soruTxt;
    public Text skorTxt;
    public Text sonucTxt;
    public Button sonucButton;
    public Button hesapMakinesiButton;

    int toplamSoru;
    public int skor;

    private void Start()
    {
        toplamSoru = soruVeCevaplar.Count;
        oyunBittiPanel.SetActive(false);
        sonrakiSoruPanel.SetActive(false);
        soruUret();
    }

    public void tekrar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void hesapMakinesineGit(){
        SceneManager.LoadScene("SampleScene");
    }

    void oyunBitti()
    {
        skorTxt.text = skor + "/" + toplamSoru;
        sonrakiSoruPanel.SetActive(false);
        oyunBittiPanel.SetActive(true);
    }

    public void dogru()
    {
        skor += 1;
        soruVeCevaplar.RemoveAt(mevcutSoru);
        cevapBtn1.image.color = Color.green;
        sonucTxt.text = "DOĞRU";
        sonucTxt.color = Color.white;

        if (soruVeCevaplar.Count > 0)
        {
            soruPanel.SetActive(false);
            sonrakiSoruPanel.SetActive(true);
        }
        else
        {
            Debug.Log("Sorular Bitti!");
            sonucButton.GetComponentInChildren<Text>().text = "SONUÇLAR";
            soruPanel.SetActive(false);
            sonrakiSoruPanel.SetActive(true);
            sonucButton.onClick.AddListener(oyunBitti);
            //oyunBitti();
        }
    }
    public void yanlis()
    {
        soruVeCevaplar.RemoveAt(mevcutSoru);
        cevapBtn1.image.color = Color.red;
        sonucTxt.text = "YANLIŞ";
        sonucTxt.color = Color.white;

        if (soruVeCevaplar.Count > 0)
        {
            soruPanel.SetActive(false);
            sonrakiSoruPanel.SetActive(true);
        }
        else
        {
            Debug.Log("Sorular Bitti!");
            sonucButton.GetComponentInChildren<Text>().text = "SONUÇLAR";
            soruPanel.SetActive(false);
            sonrakiSoruPanel.SetActive(true);
            sonucButton.onClick.AddListener(oyunBitti);

            //oyunBitti();
        }
    }

    void CevapAyarla()
    {
        for (int i = 0; i < secenekler.Length; i++)
        {
            secenekler[i].GetComponent<CevapScript>().dogruMu = false;
            secenekler[i].transform.GetChild(0).GetComponent<Text>().text = soruVeCevaplar[mevcutSoru].cevaplar[i];

            if (soruVeCevaplar[mevcutSoru].dogruCevap == i + 1)
            {
                secenekler[i].GetComponent<CevapScript>().dogruMu = true;
            }
        }
    }

    public void soruUret()
    {
        if (soruVeCevaplar.Count > 0)
        {
            soruPanel.SetActive(true);
            sonrakiSoruPanel.SetActive(false);
            mevcutSoru = Random.Range(0, soruVeCevaplar.Count);
            soruTxt.text = soruVeCevaplar[mevcutSoru].soru;
            CevapAyarla();
        }
        else
        {
            Debug.Log("Sorular Bitti!");
            oyunBitti();
        }
    }
}
