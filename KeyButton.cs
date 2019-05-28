using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyButton : MonoBehaviour {

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
        button = GetComponent<Button>();
        button.onClick.AddListener(() => Function());
    }

    void Function()
    {
        words.WriteLetter(Letter, index);
        text.text = Space.ToString();
        button.enabled = false;
    }

    public void Reactivate()
    {
        text.text = Letter.ToString();
        button.enabled = true;
    }
}
