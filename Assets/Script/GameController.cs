using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Vector3 mainPosition;

    private bool winGame;
    public bool win = false;

    void Start()
    {
        mainPosition = transform.position;
        winGame = false;
    }

    void Update()
    {
        win = winGame;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Vehicle"))
        {
            StartCoroutine(WaitSecond());
            
        }

        if(other.gameObject.CompareTag("FinishGame"))
        {
            GameWin();
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void GameWin()
    {
        winGame = true;
    }

    IEnumerator WaitSecond()
    {
        yield return new WaitForSeconds(3);
        GameOver();
    }
}
