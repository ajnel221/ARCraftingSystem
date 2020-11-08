using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageRecognition : MonoBehaviour
{
    ARTrackedImage _ARTrackedImage;
    [SerializeField] Text nameText;
    [SerializeField] GameObject[] cards;
    GameObject itemCheckerObject;
    ItemChecker itemChecker;
    Restart itemRestart;
    public bool iron = false;
    public bool gold = false;
    public bool black = false;
    public bool blue = false;
    public bool green = false;
    public bool red = false;
    public bool ironIngot = false;
    public bool goldIngot = false;
    public bool blackIngot = false;
    public bool blueIngot = false;
    public bool greenIngot = false;
    public bool redIngot = false;

    void Start()
    {
        _ARTrackedImage = GetComponent<ARTrackedImage>();
        //CheckName(_ARTrackedImage.referenceImage.name);
        itemCheckerObject = GameObject.Find("ItemChecker");
        itemChecker = itemCheckerObject.GetComponent<ItemChecker>();
        itemRestart = itemCheckerObject.GetComponent<Restart>();
        CheckNamesOfItems();
    }

    void Update()
    {
        CheckBoolStatusIron();
        CheckBoolStatusGold();
        CheckBoolStatusBlack();
        CheckBoolStatusBlue();
        CheckBoolStatusGreen();
        CheckBoolStatusRed();

        if(ironIngot == true)
        {
            itemChecker.ironIngot = true;
        }

        if(goldIngot == true)
        {
            itemChecker.goldIngot = true;
        }

        if(blackIngot == true)
        {
            itemChecker.blackIngot = true;
        }

        if(blueIngot == true)
        {
            itemChecker.blueIngot = true;
        }

        if(greenIngot == true)
        {
            itemChecker.greenIngot = true;
        }

        if(redIngot == true)
        {
            itemChecker.redIngot = true;
        }
    }

    /*void CheckName(string name)
    {
        nameText.text = name;

        switch(name)
        {
            case "IronIngot":
                cards[0].SetActive(true);
                ironIngot = true;
                break;
            
            case "GoldIngot":
                cards[1].SetActive(true);
                goldIngot = true;
                break;

            case "BlackIngot":
                cards[2].SetActive(true);
                blackIngot = true;
                break;
        }
    }*/

    public void CheckNamesOfItems()
    {
        if(_ARTrackedImage.referenceImage.name == "IronIngot")
        {
            cards[0].SetActive(true);
            iron = true;
            nameText.text = _ARTrackedImage.referenceImage.name;
        }

        else if(_ARTrackedImage.referenceImage.name == "GoldIngot")
        {
            cards[1].SetActive(true);
            gold = true;
            nameText.text = _ARTrackedImage.referenceImage.name;
        }

        else if(_ARTrackedImage.referenceImage.name == "BlackIngot")
        {
            cards[2].SetActive(true);
            black = true;
            nameText.text = _ARTrackedImage.referenceImage.name;
        }

        else if(_ARTrackedImage.referenceImage.name == "BlueIngot")
        {
            cards[3].SetActive(true);
            blue = true;
            nameText.text = _ARTrackedImage.referenceImage.name;
        }

        else if(_ARTrackedImage.referenceImage.name == "GreenIngot")
        {
            cards[4].SetActive(true);
            green = true;
            nameText.text = _ARTrackedImage.referenceImage.name;
        }

        else if(_ARTrackedImage.referenceImage.name == "RedIngot")
        {
            cards[5].SetActive(true);
            red = true;
            nameText.text = _ARTrackedImage.referenceImage.name;
        }
    }

    public void CheckBoolStatusIron()
    {
        if(iron == true && itemRestart.resetStuff == false)
        {
            ironIngot = true;
        }

        else
        {
            ironIngot = false;
        }
    }

    public void CheckBoolStatusGold()
    {
        if(gold == true && itemRestart.resetStuff == false)
        {
            goldIngot = true;
        }

        else
        {
            goldIngot = false;
        }
    }

    public void CheckBoolStatusBlack()
    {
        if(black == true && itemRestart.resetStuff == false)
        {
            blackIngot = true;
        }

        else
        {
            blackIngot = false;
        }
    }

    public void CheckBoolStatusBlue()
    {
        if(blue == true && itemRestart.resetStuff == false)
        {
            blueIngot = true;
        }

        else
        {
            blueIngot = false;
        }
    }

    public void CheckBoolStatusGreen()
    {
        if(green == true && itemRestart.resetStuff == false)
        {
            greenIngot = true;
        }

        else
        {
            greenIngot = false;
        }
    }

    public void CheckBoolStatusRed()
    {
        if(red == true && itemRestart.resetStuff == false)
        {
            redIngot = true;
        }

        else
        {
            redIngot = false;
        }
    }
}