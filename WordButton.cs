using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordButton : MonoBehaviour {

    public Words words;
    public Text buttonText;
    private Button button;
    public int SavedIndex;


    void Awake()
    {
        buttonText = GetComponentInChildren<Text>();
        button = GetComponent<Button>();
        button.onClick.AddListener(() => Function());
        
    }

    void Function()
    {
        words.DeleteLetter(this);
        
    }
  
}
