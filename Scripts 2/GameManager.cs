using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject PowerUp;
    private bool isPlayerAlive;
    private int score;
    private int lives;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI powerupText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        lives = 3;
        livesText.text = "Lives: " + lives;
        isPlayerAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
