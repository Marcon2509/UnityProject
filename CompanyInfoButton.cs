using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompanyInfoButton : MonoBehaviour
{
    
    public static Sprite image1, image2, image3, image4;
    public Image imagedisplay1;
    public Image imagedisplay2;
    public Sprite[] imageArr = new Sprite[] {image3, image4 };
    
    void Start()
    {
        imagedisplay1.sprite = image1;
        imagedisplay2.sprite = image2;
    }

    public void buttonOnclick()
    {
       
        imageDisplayer(imageArr);
    }


    public void imageDisplayer(Sprite[] imageArr2)
    {
        
        imagedisplay1.sprite = imageArr2[0];
        imagedisplay2.sprite = imageArr2[1];

    }
}
