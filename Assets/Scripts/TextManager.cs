using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] private string vegetablesCollected;
    [SerializeField] private string vegetablesNeeded;
    [SerializeField] private int currentTextIndex;
    [SerializeField] private GameObject[] questTest;
    
    void Awake()
    {
        currentTextIndex = Random.Range(0, questTest.Length);
        questTest[currentTextIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
