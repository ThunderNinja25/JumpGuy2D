using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject nextLevelScreen;
    private GameManager gameManager;
    [SerializeField] private UnityEvent levelLoad;
    
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

    public void Restart1()
    {
        SceneManager.LoadScene(1);
    }

    public void Restart2()
    {
        SceneManager.LoadScene(2);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
