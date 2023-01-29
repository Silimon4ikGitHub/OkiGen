using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour
{
    [SerializeField] private Animator myAnimator;
    void Awake()
    {
        myAnimator = gameObject.GetComponent<Animator>();
    }
}
