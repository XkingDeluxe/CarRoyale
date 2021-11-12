using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1 : MonoBehaviour
{
    //---------------------External
    public Transform fObj;
    //---------------------
    //Offsets
    public Vector3 off1;
    public static Vector3 off2;

    //Speed settings
    public float followSpeed = 10;
    public float rotateSpeed = 10;

    private void FixedUpdate()
    {
        //Call functions
        RotateToTarget();
        //Check if player two is in reset mode
        if (PlayerOneController.reset == false)
        {
            GoToTarget();
        }
    }

    //Point towards target
    public void RotateToTarget()
    {
        Vector3 dir = fObj.position - transform.position;
        Quaternion rot = Quaternion.LookRotation(dir, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, rotateSpeed * Time.deltaTime);
    }

    //Follow target
    public void GoToTarget()
    {
        Vector3 targetPos = fObj.position + fObj.forward * (off1.z+off2.z) + fObj.right * (off1.x + off2.x) + fObj.up * (off1.y + off2.y);
        transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);
    }
}
