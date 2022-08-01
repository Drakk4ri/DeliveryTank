using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI beginningScoreText;

    private void Start()
    {
        beginningScoreText.text = "DELIVER 3 AMMO PACKS TO GENERALLE";
    }
}
