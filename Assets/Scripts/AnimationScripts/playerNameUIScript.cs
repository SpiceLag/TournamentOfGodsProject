using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class playerNameUIScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator playerNameAnimator;
    private bool mouse_over;
    private bool isHover; 

    void Start()
    {
        playerNameAnimator = GetComponent<Animator>();
        mouse_over = false;
        isHover = false;
    }

    void Update()
    {
        if (mouse_over)
        {
            //Debug.Log("Mouse Over");
        }
    }
 
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        //Debug.Log("Mouse enter");
        if(!this.isHover){
            playerNameAnimator.SetBool("isHover",true);
            isHover = true;
        }
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        //Debug.Log("Mouse exit");
        if(this.isHover){
            playerNameAnimator.SetBool("isHover",false);
            isHover = false;
        }
    }
}
