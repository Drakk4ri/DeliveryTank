using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;


public class PointSystem : MonoBehaviour
{
    public static PointSystem instance;

    public UnityEvent GameWon;

    private int points = 0;
    private int pointsToWin = 2;


    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        //scoreText.text = "DELIVER 3 AMMO PACKS TO GENERALLE";

    }

    public void Update()
    {
 
    }

    public void AddPoint()
    {
        points++;
        scoreText.text = "YOU DELIVERED: \n" + points + "/3 AMMO PACKS";
        if (points == pointsToWin)
        {
            GameWon.Invoke();
            Debug.Log("dUPA");
        }

    }

}
