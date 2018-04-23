using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;

    void Start () {
        Cursor.visible = false;
    }
	
	void Update () {
        showScore();
    }

    private void showScore()
    {
        scoreText.text = "Score: " + PlayerStats.Kills;
    }
}
