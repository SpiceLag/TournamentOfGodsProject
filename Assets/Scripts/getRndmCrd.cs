using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getRndmCrd : MonoBehaviour
{
    private int slotCounter;
    public int maxSlotsvalue;
    private Image imgComp;
    private Transform parent;
    public Sprite[] images;
    public GameObject btnPref;
    public GameObject verticalGroup;

    // Start is called before the first frame update
    void Start()
    {
        parent = verticalGroup.transform;
        slotCounter = 0;
    }

    private int showRandomImage () {
        //Counts the images
        int count = images.Length;
        //Random number select between images
        int index = Random.Range(0, count);
        //Return the random number;   
        return index;
    }

    void OnMouseDown(){
        Debug.Log("AAAAGH Me están haciendo click!! D:");
        if(slotCounter >= maxSlotsvalue){
            Debug.Log("Has alcanzado el limite de cartas!!");
        }else{
            GameObject myBtn = Instantiate(btnPref, parent);
            imgComp = myBtn.GetComponent<Image>();
            imgComp.sprite = images[showRandomImage()];
            slotCounter++;
        }
    }
}
