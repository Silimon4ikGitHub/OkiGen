using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorPhysics : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform forwardEdge;
    [SerializeField] private Transform aftEdge;
    [SerializeField] private Rigidbody conveyorRB;

    void Update()
    {
       ConveyorPhysicsOn();
    }
    
    void ConveyorPhysicsOn()
    {
        Vector3 pos = conveyorRB.position;
        conveyorRB.position += Vector3.right * speed * Time.fixedDeltaTime;
        conveyorRB.MovePosition(pos);
    }
}
