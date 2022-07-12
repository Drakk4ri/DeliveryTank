using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public static PointSystem instance;

    
    private int points = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        scoreText.text = "YOU DELIVERED: \n" + points + " AMMO PACKS";
    }

    public void AddPoint()
    {
        points++;
        scoreText.text = "YOU DELIVERED: \n" + points + " AMMO PACKS";
    }
}
