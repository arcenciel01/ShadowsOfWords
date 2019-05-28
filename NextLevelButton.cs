using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour {

    public int NextLevel;
	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(() => Function());
    }
	
	void Function ()
    {
        SceneManager.LoadScene(NextLevel);
    }
}
