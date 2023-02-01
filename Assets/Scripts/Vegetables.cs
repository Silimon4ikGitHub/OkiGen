using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetables : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationOffset = 270f;
    [SerializeField] private Transform bunnyHand;
    [SerializeField] private Transform disappearPoint;
    [SerializeField] private Rigidbody myRB;
    public bool isClicked;
    public int myTypeIndex;

    void Awake()
    {
        bunnyHand = GameObject.FindGameObjectWithTag("CatchPoint").transform;
        disappearPoint = GameObject.FindGameObjectWithTag("DestroyPoint").transform;
        myRB = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (isClicked)
        {
            MoveInHand();
        }
        if (!isClicked)
        {
            myRB.useGravity = true;
        }

        DissapearInEnd();
    }

    private void OnMouseDown() 
    {
        isClicked = true;
    }

    private void MoveInHand()
    { 
        transform.position = Vector3.MoveTowards(transform.position, bunnyHand.position, speed);
        transform.rotation = Quaternion.Euler(0,0,rotationOffset);
        myRB.useGravity = false;
    }

    private void DissapearInEnd()
    {
        if (transform.position.x < disappearPoint.position.x)
        {
            Destroy(gameObject);
        }
    }
}
