using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorPhysics : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform forwardEdge;
    [SerializeField] private Transform aftEdge;

    void Update()
    {
       ConveyorPhysicsOn();
    }
    
    void ConveyorPhysicsOn()
    {
        var step = speed * Time.deltaTime;
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, forwardEdge.localPosition, step);
        if(transform.localPosition == forwardEdge.localPosition)
        {
            transform.localPosition = aftEdge.localPosition;
        }
    }
}
