using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EndScreen : MonoBehaviour
{
    [SerializeField] Button restartButton;

    [SerializeField] private TextMeshProUGUI endGameScoreText;
    private void Start()
    {
        restartButton = FindObjectOfType<Button>();
        endGameScoreText.text = "CONGATUATIONS! YOU DELIVERED ALL AMMO PACKS!";
    }


}
