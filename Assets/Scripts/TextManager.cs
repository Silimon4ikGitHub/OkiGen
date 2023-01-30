using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemCollectedText;
    [SerializeField] private LevelManager levelManagerScript;
    [SerializeField] private int itemToCllect;
    public int questItemCollected;

    
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        itemToCllect = levelManagerScript.itemTocollectCount;
        ShowCollectedItemsCount();
    }

    private void ShowCollectedItemsCount()
    {
        itemToCllect.ToString();
        questItemCollected.ToString();
        itemCollectedText.text = questItemCollected + "/" + itemToCllect;
    }
}
