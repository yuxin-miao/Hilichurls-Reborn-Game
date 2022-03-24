using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountCollection : MonoBehaviour
{
    public TextMeshProUGUI sunsettiaText;
    int sunsettiaCount;
    private void OnEnable() {
        // Sunsettia.OnSunsettiaCollected += IncrementSunsettiaCount;
    }
    private void OnDisable() {
        // Sunsettia.OnSunsettiaCollected -= IncrementSunsettiaCount;
        
    }
    public void IncrementSunsettiaCount() {
        sunsettiaCount++;
        sunsettiaText.text = $"日落果: {sunsettiaCount}";
    }
}
