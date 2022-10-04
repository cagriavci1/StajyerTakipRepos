using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SayfaGecis : MonoBehaviour
{
        public void sahnedegis(int sahneid)
        {
            SceneManager.LoadScene(sahneid);
        }
    
    void Start()
    {
       
    }


}