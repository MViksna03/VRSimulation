using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInteraction : MonoBehaviour
{
    public LayerMask interactionLayer;
    public float raycastDistance = 10f;

    private void Update()
    {

        if (Input.GetButtonDown("XRInteract")) 
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(ray, out hit, raycastDistance))
            {
                string objectName = hit.collider.gameObject.name;
                Debug.Log("Hit object name: " + objectName);
                ObjectScript objectScript = hit.transform.GetComponent<ObjectScript>();

                if (objectScript != null)
                {
                    objectScript.Interact();
                }
            }
        }
    }
}