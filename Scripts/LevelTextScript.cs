using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelTextScript : MonoBehaviour {
    public Text levelText;
	// Use this for initialization
	void Start () {
        levelText.text = "Level: " + (SceneManager.GetActiveScene().buildIndex + 1).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
