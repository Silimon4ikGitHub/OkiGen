using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DitzelGames.FastIK;

public class BunnyHand : MonoBehaviour
{
    [SerializeField] private float offsetZ;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;
    [SerializeField] private float speed;
    [SerializeField] private Material effectMaterial;
    [SerializeField] private GameObject effectObject;
    [SerializeField] private GameObject levelPassedText;
    [SerializeField] private GameObject nextLevelButton;
    [SerializeField] private Vector3 centerPosition;
    [SerializeField] private Animator myAnimator;
    [SerializeField] private Animator cameraAnimator;
    [SerializeField] private FastIKFabric fastIK;
    [SerializeField] private Collider myCollider;
    [SerializeField] private GameObject basket;
    [SerializeField] private Vegetables vegetableScript;
    [SerializeField] private LevelManager levelManagerScript;
    private Vector3 myPosition;
    private Vector3 screenMousePosition;
    private Vector3 worldMousePosition;
    public int catchedItemIndex;

    void FixedUpdate()
    {
        MoveHandOnMouse();
    }

    private void MoveHandOnMouse()
    {
        transform.position = myPosition;
        screenMousePosition = Input.mousePosition;
        screenMousePosition.z = Camera.main.nearClipPlane;
        worldMousePosition = Camera.main.ScreenToWorldPoint(screenMousePosition) - centerPosition;
        myPosition.z = offsetZ;
        myPosition.x = worldMousePosition.x * offsetX;
        myPosition.y = worldMousePosition.y * offsetY;
    }

    private void OnTriggerEnter(Collider collision)
    {
        GameObject catchedVegetable = collision.gameObject;
        vegetableScript = catchedVegetable.GetComponent<Vegetables>();
        
        if (catchedVegetable.GetComponent<Vegetables>())
        {
            SwitchOffFastIK();
            myAnimator.SetBool("isClick", true);
            myCollider.enabled = false;
            Invoke("SwitchOnFastIK", 1.0f);

            vegetableScript.isClicked = false;

            MoveVegetableToBasket(catchedVegetable);

            effectObject.SetActive(true);

            catchedItemIndex = vegetableScript.myTypeIndex;

            if(catchedItemIndex == levelManagerScript.questIndex)
            {
                levelManagerScript.itemCollectedCount++;
            }
            
        }
    }

    private void SwitchOnFastIK()
    {
        fastIK.enabled = true;
        myCollider.enabled = true;
        myAnimator.SetBool("isClick", false);
        effectObject.SetActive(false);
    }
    private void SwitchOffFastIK()
    {
        fastIK.enabled = false;
        
    }

    private void MoveVegetableToBasket(GameObject vegetable)
    {
        bool isInBasket = false;
        
        if(vegetable.transform.position == basket.transform.position)
        {
            isInBasket = true;
        }
        if (!isInBasket)
        {
            vegetable.transform.position = Vector3.MoveTowards(vegetable.transform.position, basket.transform.position, speed);
        }
    }

    public void FinishLevel()
    {
        myAnimator.SetBool("isDance", true);
        cameraAnimator.SetBool("isQuestComplete", true);
        levelPassedText.SetActive(true);
        nextLevelButton.SetActive(true);
        SwitchOffFastIK();
        basket.SetActive(false);
    }
}
