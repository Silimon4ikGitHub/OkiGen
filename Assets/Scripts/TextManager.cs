using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] private int itemToCllect;
    [SerializeField] private TextMeshProUGUI itemCollectedText;
    [SerializeField] private LevelManager levelManagerScript;
    public int questItemCollected;
    
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
