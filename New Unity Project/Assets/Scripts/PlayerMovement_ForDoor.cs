using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_ForDoor : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.tag);
                if (hit.transform.tag == "button")
                {
                    Debug.Log("Hit");

                    Vector3 pos = hit.transform.position;
                    Quaternion rot = Quaternion.Euler(0, 0, 0);



                }
                else
                {
                    print("nothing here!");
                }
            }

        } */

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        
    }
}
