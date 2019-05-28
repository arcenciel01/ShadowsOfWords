using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Words : MonoBehaviour
{
    public KeyButton[] KeyButtons;
    public WordButton[] WordButtons;
    int Index;
    public string rightWord;
    public GameObject WinPanel;
    

    public void Update()
    {
        
    }

    private void Awake()
    {
        Index = 0;
    }

    public void WriteLetter(char Letter, int index)
    {

        if (-1 < Index && WordButtons.Length > Index)
        {
            WordButtons[Index].buttonText.text = Letter.ToString();     // change text
            WordButtons[Index].SavedIndex = index;                     // change index
            Index += 1;
            CheckWin();
        }
    }


    public void Start()
    {
      
    }

    private bool CheckWin()
    {

        for (int i = 1; i <= WordButtons.Length; i++)
        {
            if (WordButtons[i - 1].buttonText.text == "" ||
                WordButtons[i - 1].buttonText.text[0] != rightWord[i - 1])
            {
                return false;
            }
        }

        WinPanel.SetActive(true);
        return true;

    }

    public void DeleteLetter(WordButton buttonText)
    {
        if (Index - 1 > -1)
        {
            if (WordButtons[Index - 1] == buttonText && 0 < Index && WordButtons.Length + 1 > Index)
            {
                KeyButtons[buttonText.SavedIndex].Reactivate();
                WordButtons[Index - 1].buttonText.text = "";
                Index -= 1;
            }
        }
    } 
}
