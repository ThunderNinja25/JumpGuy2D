using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject nextLevelScreen;
    private GameManager gameManager;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void PlayerDead()
    {
        gameOverScreen.SetActive(true);
    }

    public void NextLevel()
    {
        nextLevelScreen.SetActive(true);
        
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
