using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oyun_Start : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        

    }
   public void sahne_gecis() 
    {
        int sahne_index = SceneManager.GetActiveScene().buildIndex;//sahne arasý geçiþ
        if (sahne_index == 0)
        {
            SceneManager.LoadScene(1);

        }
        else if (sahne_index == 1)
        {
            SceneManager.LoadScene(0);

        }

    }
}
