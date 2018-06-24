﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this class is called when the eat button is clicked
//this class read information from the contain
//give the list of elements, that can be digested into
//show the information goe from the list in the eat option box and trigger the box
public class EatSelected : MonoBehaviour {

    public Button bt;
    public GameObject eatOption;
    //public HorizontalLayoutGroup runeImageList;

    //dk hwo to add image into the layout by script
    //using public image reference instead
    public GameObject[] eleImage =  new GameObject[5];

    public Text digestHelper;
    public List<Element> eleList;

	void Start () {
        bt.onClick.AddListener(triggerEatOption);
    }
	
	void triggerEatOption() {
        eatOption.SetActive(true);  //enable the option box

        string temp = "";

        //update info based on the given element

        //load and add elements name
        foreach (Element ele in eleList)
        {
            temp += "   " + ele.name;
        }
        digestHelper.text = temp;

        //load and add rune image of the elements
        //disable all image first
        foreach (GameObject img in eleImage){
           img.SetActive(false);
        }
        int counter = 0;
        Image[] tempImag = new Image[5];
        foreach (Element ele in eleList)
        {
            tempImag[counter] = eleImage[counter].GetComponentInChildren<Image>();
            tempImag[counter].sprite = ele.elementImage;
            eleImage[counter].SetActive(true);
            counter++;
        }
    }
}
