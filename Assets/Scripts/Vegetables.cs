using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetables : MonoBehaviour
{
    public bool isClicked;
    public int myTypeIndex;
    [SerializeField] private float speed;
    [SerializeField] private float rotationOffset = 270f;
    [SerializeField] private Transform bunnyHand;
    [SerializeField] private Rigidbody myRB;
    void Awake()
    {
        bunnyHand = GameObject.FindGameObjectWithTag("CatchPoint").transform;
        myRB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
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
}
