using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Vector3 mainPosition;

    private bool winGame;
    public bool win = false;
    public bool isCollision;

    private string nameObject = "";
    public int pointCollision;
    public ParticleSystem blowEffect;

    void Start()
    {
        mainPosition = transform.position;
        winGame = false;
        blowEffect.Stop();
    }

    void Update()
    {
        win = winGame;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Vehicle"))
        {
            blowEffect.Play();
            StartCoroutine(WaitSecondGameOver());
            
        }
        if(other.gameObject.CompareTag("FinishGame"))
        {
            winGame = true;
            StartCoroutine(WaitSecondGameWin());
        }
    }

    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.CompareTag("Obstacle") && other.gameObject.name != nameObject)
        {
            isCollision = true;
            nameObject = other.gameObject.name;
            pointCollision++;
        }else if(other.gameObject.name == nameObject)
        {
            isCollision = false;
        }
    }
    
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            isCollision = false;
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void GameWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator WaitSecondGameOver()
    {
        yield return new WaitForSeconds(3);
        GameOver();
    }

    IEnumerator WaitSecondGameWin()
    {
        yield return new WaitForSeconds(5);
        GameWin();
    }
}
