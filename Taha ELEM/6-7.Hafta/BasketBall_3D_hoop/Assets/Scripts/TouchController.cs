using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchController : MonoBehaviour,IPointerDownHandler,IDragHandler,IPointerUpHandler
{
    private float startposx, startposy;
    private float currentposx, currentposy;
    public float sliderhorizontal { get;  set; }
    public float slidervertical { get; set; }



    public void OnPointerDown(PointerEventData eventData) //dokundu�umuzdad
    {
        startposx = eventData.position.x;
        startposy = eventData.position.y;

       
    }

    public void OnDrag(PointerEventData eventData)//s�r�kledi�imzde
    {
       currentposx = eventData.position.x;
        currentposy = eventData.position.y;
        //0-25
        if (startposx-currentposx<-20)
        {
            sliderhorizontal = Mathf.Clamp(sliderhorizontal += 0.08f, min: -1f, max: 1f);
            startposx = currentposx;// ba�lang�� konumu sondaki konuma e�itle
        }
        if (startposx - currentposx > 20)
        {
            sliderhorizontal = Mathf.Clamp(sliderhorizontal -= 0.08f, min: -1f, max: 1f);
            startposx = currentposx;// ba�lang�� konumu sondaki konuma e�itle
        }

        if (startposy-currentposy<-20)
        {

            slidervertical = Mathf.Clamp(slidervertical += 0.08f, min: -1f, max: 40f);
            startposy = currentposy;

        }
        if (startposy - currentposy >20)
        {

            slidervertical = Mathf.Clamp(slidervertical -= 0.08f, min: -1f, max: 40f);
            startposy = currentposy;

        }








    }
    public void kamera_rot_reset() 
    {

        sliderhorizontal = 0f;
        slidervertical = 0f; 


    }
    public void OnPointerUp(PointerEventData eventData) 
    {
        // sliderhorizontal = startposx;
        // slidervertical = startposy; ;
        
    
    }


   
}
