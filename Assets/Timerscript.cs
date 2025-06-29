using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timerscript : MonoBehaviour
{
    PhysicsButton value;
    [SerializeField] private TextMeshProUGUI GamingText;
    [Header("Component")]
    public TextMeshProUGUI timertext;
    [Header("Timer Settings")]
    public float currentTime;
    private bool check = true;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        value = FindObjectOfType<PhysicsButton>();
        string correctBone = value.correctBoneName;
        bool bol = value.objectbool;
        if (GamingText.text == "Choose The correct bone:" + correctBone || GamingText.text == "Incorrect! Keep trying:"+correctBone)
        {
            
            currentTime += Time.deltaTime;
            timertext.text = currentTime.ToString("0.00");
        }
        if (GamingText.text == "Correct! Press the button to play again!")
        {
            
            timertext.text = currentTime.ToString("0.00");
            
        }
        if (!bol)
        {
            Reset();
        }
       
        
    }
    void Reset()
    {
        
        currentTime = 0;
        
    }
}
