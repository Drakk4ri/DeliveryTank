
using TMPro;
using UnityEngine;



public class PointSystem : MonoBehaviour
{
    public static PointSystem instance;

    public delegate void GameWon();
    public static event GameWon OnGameWon;


    private int points = 0;
    private int pointsToWin = 3;


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
            
            if (OnGameWon != null)
            {
                OnGameWon();
            }
         
        }

    }

}
