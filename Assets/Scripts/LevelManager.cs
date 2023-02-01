using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int[] questItemMaxCount;
    [SerializeField] private GameObject[] questTest;
    [SerializeField] private TextManager textScript;
    [SerializeField] private BunnyHand bunnyHandScript;

    public int questIndex;
    public int itemTocollectCount;
    public int itemCollectedCount;

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

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
