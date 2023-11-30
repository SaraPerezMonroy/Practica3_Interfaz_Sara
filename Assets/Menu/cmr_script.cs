using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmr_script : MonoBehaviour
{

bool cmr_status = true;
Camera cmr;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0f,5f, 53f);
        cmr = gameObject.GetComponent<Camera>();
        cmr.usePhysicalProperties = true;
        cmr_status = true;
       
                 }

    // Update is called once per frame
    void Update()
    {
       float move_x =  Input.GetAxis("Horizontal");
       float move_z =  Input.GetAxis("Vertical");
     
       if (!Input.GetKey(KeyCode.R)) transform.position = transform.position + (transform.forward*move_z + transform.right*move_x)*20f*Time.deltaTime;
       if (!Input.GetKey(KeyCode.E)) transform.position = transform.position - transform.up*20f*Time.deltaTime;
       if (!Input.GetKey(KeyCode.D)) transform.position = transform.position + transform.up*20f*Time.deltaTime;
       if (Input.GetKey(KeyCode.R) && Mathf.Abs(Input.GetAxis("Horizontal")) > 0) transform.Rotate(0f,40f*Time.deltaTime*Mathf.Sign(move_x),0f,Space.World);
       
       if (Input.GetKeyDown(KeyCode.Z)) cmr_status = !cmr_status; //change from between zoom / not zoom states
       
       if (cmr_status && cmr.focalLength > 50) cmr.focalLength -= 30f*Time.deltaTime;
       if (!cmr_status && cmr.focalLength < 130) cmr.focalLength += 30f*Time.deltaTime;
       
                                                                                  
    } // end of Update()
}
