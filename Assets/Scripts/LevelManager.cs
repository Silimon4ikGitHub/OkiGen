using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int itemCollect;
    [SerializeField] private TextManager textScript;
    [SerializeField] private BunnyHand bunnyHandScript;
    [SerializeField] private GameObject[] questTest;
    public int itemCollectedCount;
    [SerializeField] private int[] questItemIndex;
    [SerializeField] private int[] questItemMaxCount;
    public int questIndex;
    public int itemTocollectCount;
    void Awake()
    {
        questIndex = Random.Range(0, questTest.Length);
        questTest[questIndex].SetActive(true);
        itemTocollectCount = questItemMaxCount[questIndex];
    }

    void Update()
    {
        AddQuestItemCount();

        if (itemCollectedCount >= itemTocollectCount)
        {
            bunnyHandScript.FinishLevel();
        }
            
        
    }

    private void AddQuestItemCount()
    {
        
            textScript.questItemCollected = itemCollectedCount;
        
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
