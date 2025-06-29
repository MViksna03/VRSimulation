using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ObjectScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI GamingText;
    private string correctBoneName;

    public UnityEvent onPressed, onReleased;

    public string[] bones = { "Cranium Bone", "Femur Bone", "LumbarVertebrae Bone" };

    void Start()
    {
        int randomIndex = UnityEngine.Random.Range(0, bones.Length);
        correctBoneName = bones[randomIndex];
    }

    public void Interact()
    {
        string selectedBoneName = gameObject.name;

        if (selectedBoneName == correctBoneName)
        {
            GamingText.text = "Correct!";
        }
        else
        {
            GamingText.text = "Incorrect!";
        }
    }
}