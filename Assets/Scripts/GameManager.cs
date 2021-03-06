using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool _isGameOver;

    private void Update() {
        //restart the game if R key is pressed.
        if (Input.GetKeyDown(KeyCode.R) && _isGameOver) {
            //SceneManager.LoadScene("Game"); Strings are slower
            SceneManager.LoadScene(0); // Current Game Scene is scene 0
        }
    }

    public void GameOver() {
        //Debug.Log("GameManager::GameOver() Called");
        _isGameOver = true;
    }
}
