using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightLetter : MonoBehaviour {

    public Words words;
    private Button button;

    public int index;

    private Text text;

    public char Letter = 'A';
    public char Space = ' ';

   


    void Awake()
    {
        text = GetComponentInChildren<Text>();
        text.text = Letter.ToString();
    }


}
