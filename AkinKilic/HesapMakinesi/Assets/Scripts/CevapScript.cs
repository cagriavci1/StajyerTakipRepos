using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CevapScript : MonoBehaviour
{
    public bool dogruMu = false;
    public SoruYonetim soruYonetim;
    public void cevap(){
        if (dogruMu)
        {
            Debug.Log("Doğru Cevap");
            soruYonetim.dogru();
        }
        else
        {
            Debug.Log("Yanlış Cevap");
            soruYonetim.yanlis();
        }
    }
}
