using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text textComponent;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            score++;
        }
        textComponent.text = "Score: " + score;
    }
}
