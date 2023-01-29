using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour
{
    [SerializeField] private Vegetables itemScript;
    [SerializeField] private Animator myAnimator;
    [SerializeField] private GameObject handPoint;
    [SerializeField] private Collider handCollider;
    // Start is called beforeFastIKFabric the first frame update
    void Awake()
    {
        myAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if (handCollider.gameObject.GetComponent<Vegetables>())
        {
            Debug.Log("Here is working");
            handPoint.SetActive(false);
            myAnimator.SetBool("isClick", true);
            
        }
    }
}
