using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class verticalImageScript : MonoBehaviour
{
   // public static Sprite image1, image2, image3, image4;
    public Image imagedisplay1;
    public Image imagedisplay2;
   // public Sprite[] imageArr = new Sprite[] { image1, image2, image3, image4 };
    // Start is called before the first frame update
  

    public void imageDisplayer(Sprite[] imageArray)
    {
        imagedisplay1.sprite = imageArray[0];
        imagedisplay2.sprite = imageArray[1];

    }
}
