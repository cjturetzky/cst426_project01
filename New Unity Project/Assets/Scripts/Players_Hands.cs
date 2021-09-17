using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players_Hands : MonoBehaviour
{

    private GameObject heldObj;

    public float pickUpRange = 5;

    public Transform holdParent;

    public float moveForce = 200;

    // Start is called before the first frame update
    /**void Start()
    {
        
    }**/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldObj == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange))
                {
                    PickUpObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }

        if (heldObj != null)
        {
            MoveObject();
        }

    }

    void DropObject()
    {
        Rigidbody heldRig = heldObj.GetComponent<Rigidbody>();
        heldRig.useGravity = true;
        heldRig.drag = 1;

        heldObj.transform.parent = null;
        heldObj = null;
    }

    void MoveObject()
    {

        if (Vector3.Distance(heldObj.transform.position, holdParent.position) > 0.1f)
        {
            Vector3 mDir = (holdParent.position - heldObj.transform.position);

            heldObj.GetComponent<Rigidbody>().AddForce(mDir * moveForce);
        }

    }


    void PickUpObject(GameObject pickObj)
    {

        if (pickObj.GetComponent<Rigidbody>())
        {

            Rigidbody objRig = pickObj.GetComponent<Rigidbody>();
            objRig.useGravity = false;
            objRig.drag = 10;


            objRig.transform.parent = holdParent;

            heldObj = pickObj;

        }

    }


}
