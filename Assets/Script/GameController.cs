using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Vector3 mainPosition;

    void Start()
    {
        mainPosition = transform.position;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Vehicle"))
        {
            StartCoroutine(WaitSecond());
            
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator WaitSecond()
    {
        yield return new WaitForSeconds(3);
        GameOver();
    }
}
