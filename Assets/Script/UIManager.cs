using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textVelocity;
    public TextMeshProUGUI textTime;
    public TextMeshProUGUI textScoreTime;
    public GameObject textWinGame;
    
    public PlayerController playerController;
    public GameController gameController;

    public float velocity;
    public float velAument;
    public float scoreTime;

    public bool finishGame = false;

    void Start()
    {
        textVelocity.SetText("0");
        scoreTime = 0.0f;
    }

    void FixedUpdate()
    {
        // Temporizador UI
        scoreTime += Time.deltaTime * 1;
        textTime.SetText("Time: " + scoreTime.ToString("0.00"));

        // Velocidad UI
        velocity = playerController.speedUI * velAument;
        textVelocity.SetText(velocity.ToString("0"));
        if(velocity < 0)
        {
            textVelocity.SetText("N");
        }
        
        if(gameController.win && !finishGame)
        {   
            textScoreTime.SetText("Time Score:" + scoreTime.ToString("0.00"));
            textWinGame.SetActive(true);
            finishGame = true;
        }
        
    }

    
}
