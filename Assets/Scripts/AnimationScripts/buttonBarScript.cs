using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonBarScript : MonoBehaviour
{
    //public AudioClip sound;
    public Animator buttonAnimator;
    public Animator sideBarAnimator;
    private bool isHidden;
    // Start is called before the first frame update

    void Start()
    {
        buttonAnimator = GetComponent<Animator>();
        sideBarAnimator = GetComponent<Animator>();
        isHidden = false;
    }

    public void Press()   
    {
        //AudioSource.PlayClipAtPoint(sound, transform.position);
        if(!this.isHidden){
            buttonAnimator.SetBool("canFlip",true);
            sideBarAnimator.SetBool("isHidden",true);
            isHidden = true;
        }else{
            buttonAnimator.SetBool("canFlip",false);
            sideBarAnimator.SetBool("isHidden",false);
            isHidden = false;
        }
    }
}
