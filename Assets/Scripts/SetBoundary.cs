using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBoundary : MonoBehaviour
{

    public GameObject forward;
    public GameObject backward;
    public GameObject left;
    public GameObject right;
    public bool forwardMove = true;
    public bool backwardMove = true;
    public bool leftMove= true;
    public bool rightMove = true;

    public float range = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ForwardCheck();
        BackwardCheck();
        LeftCheck();
        RightCheck();
    }
    private void ForwardCheck()
    {
        Vector3 direction = Vector3.down;
        Ray downRay = new Ray(forward.transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(forward.transform.position, transform.TransformDirection(direction * range), Color.green);
        if (Physics.Raycast(downRay, out RaycastHit hit, range))
        {
            if (hit.collider.CompareTag("Cube"))
            {
                forwardMove = true;
            }
            else
            {
                forwardMove = false;
            }


        }
    }
    private void BackwardCheck()
    {
        Vector3 direction = Vector3.down;
        Ray downRay = new Ray(backward.transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(backward.transform.position, transform.TransformDirection(direction * range), Color.green);
        if (Physics.Raycast(downRay, out RaycastHit hit, range))
        {
            if (hit.collider.CompareTag("Cube"))
            {
                backwardMove = true;
            }
            else
            {
                backwardMove = false;
            }
        }
    }

    private void LeftCheck()
    {
        Vector3 direction = Vector3.down;
        Ray downRay = new Ray(left.transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(left.transform.position, transform.TransformDirection(direction * range), Color.green);
        if (Physics.Raycast(downRay, out RaycastHit hit, range))
        {
            if (hit.collider.CompareTag("Cube"))
            {
                leftMove = true;
            }
            else
            {
                leftMove = false;
            }


        }
    }
    private void RightCheck()
    {
        Vector3 direction = Vector3.down;
        Ray downRay = new Ray(right.transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(right.transform.position, transform.TransformDirection(direction * range), Color.green);
        if (Physics.Raycast(downRay, out RaycastHit hit, range))
        {
            if (hit.collider.CompareTag("Cube"))
            {
                rightMove = true;
            }
            else
            {
                rightMove = false;
            }
        }
    }
}