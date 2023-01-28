using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour
{
    [SerializeField] private Vegetables itemScript;
    [SerializeField] private Animator myAnimator;
    //[SerializeField] private FastIKFabric IKSkript;
    // Start is called before the first frame update
    void Awake()
    {
        myAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OncollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Vegetables>())
        {
            myAnimator.SetBool("isClick", true);
        }

    }
}
