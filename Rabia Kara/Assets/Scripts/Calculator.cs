using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
     private float sonuc;
     private float input;
     private float input1;
     public TextMeshProUGUI InputText;
     private string operation;


      public void ClickNumber(int val)
    {
        Debug.Log(message:$" check val: {val}");
        InputText.text = $"{val}";
        if(input == 0)
        {
          input = val;
        }
        else
        {
            input1 = val;
        }
       
    }  

      public void ClickOperation(string val)
    {
        Debug.Log(message:$" ClickOperation val: {val}");
        operation = val;
    }

       public void ClickEqual(string val)
    {
        Debug.Log(message:$" ClickEqual val: {val}");
        if(input !=0 && input1 !=0 && !string.IsNullOrEmpty(operation))
        {
            switch (operation)
            {
            case "+":
              sonuc = input + input1;
            break;
            case "-":
              sonuc = input - input1;
            break;
            case "*":
              sonuc = input * input1;
            break;
            case "/":
            sonuc = input / input1;
            break;
            }
        InputText.SetText(sonuc.ToString());
        ClearInput();
        }
    
    }
    public void ClickPeriod(string val)
    {
        Debug.Log(message:$" ClickPeriod val: {val}");
    }
    public void ClearInput()
    {
        input = 0;
        input1 = 0;
    }

   
}
