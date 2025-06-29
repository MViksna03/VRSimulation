using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectDettection : MonoBehaviour
{
    public float range = 10;
    PhysicsButton val;
    
    [SerializeField] private TextMeshProUGUI StartingText;
    [SerializeField] private TextMeshProUGUI GamingText;
    // Update is called once per frame
    void Update()
    {
        val = FindObjectOfType<PhysicsButton>();
        string correctBone = val.correctBoneName;
        bool alsocheck = val.objectbool;
        Vector3 direction = Vector3.forward;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction*range));
        if(Physics.Raycast(theRay, out RaycastHit hit, range))
        {
            if(hit.collider.tag == "Bone")
            {
                print("Its a bone");
                string objectName = hit.collider.gameObject.name;
                Debug.Log("Hit object name: " + objectName);
                if(objectName == correctBone)
                {
                    
                    GamingText.text = "Correct! Press the button to play again!";
                }
                if (objectName != correctBone && GamingText.text != "Correct! Press the button to play again!" && GamingText.text != "")
                {
                    GamingText.text = "Incorrect! Keep trying:" + correctBone;
                }
            }

        }
    }
}
