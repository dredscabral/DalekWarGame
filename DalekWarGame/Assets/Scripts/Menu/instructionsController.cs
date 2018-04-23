using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class instructionsController : MonoBehaviour {

    int numberOfbuttons = 2;
    int indicator_position = 1;
    public Transform selector;

    public Transform button_player1;
    public Transform button_back;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (indicator_position > 1)
            {
                indicator_position -= 1;
            }
            Debug.Log(indicator_position + "");
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (indicator_position < numberOfbuttons)
            {
                indicator_position += 1;
            }
            Debug.Log(indicator_position + "");
        }

        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            switch (indicator_position)
            {
                case 1:
                    SceneManager.LoadScene("Main");
                    break;
                case 2:
                    SceneManager.LoadScene("Menu");
                    break;
                default:
                    break;
            }
        }

        //update indicator position
        switch (indicator_position)
        {
            case 1:
                selector.position = new Vector3(selector.position.x, button_player1.position.y, selector.position.z);
                break;
            case 2:
                selector.position = new Vector3(selector.position.x, button_back.position.y, selector.position.z);
                break;
            default:
                break;
        }
    }
}
