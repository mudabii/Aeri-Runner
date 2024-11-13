using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoretxt;
    float elapsedtime;
  
    void Update()
    {
        elapsedtime += Time.deltaTime;
        int seconds = Mathf.FloorToInt(elapsedtime % 60);
        scoretxt.text = (seconds).ToString("0");
    }
}
