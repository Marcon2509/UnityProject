using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighscoreScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Text highscoretext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscoretext.text = "Highscore:\n  1.  " + Stockmanagerscript.highscore[0].ToString() + "\n  2.  " + Stockmanagerscript.highscore[1].ToString() + "\n  3.  " + Stockmanagerscript.highscore[2].ToString();
    }
}
