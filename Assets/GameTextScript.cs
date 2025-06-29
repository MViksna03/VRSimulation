using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameTextScript : MonoBehaviour
{
    TextMeshProUGUI GameText;
    Text StartText;
    
    // Start is called before the first frame update
    void Start()
    {
        GameText = GameObject.Find("GameText").GetComponent<TextMeshProUGUI>();
        GameText.text = "";
        StartText = GameObject.Find("StartingText").GetComponent <Text>();
        StartText.text = "Click the button to Start!";
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void TurnOn()
    {
        GameText.text = "Choose the right bone:";
        StartText.text = "";
    }
}
