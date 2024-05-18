using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBorder : MonoBehaviour
{

    public Character player;
    public UIManager uiManager;
    public Camera cameraDeath;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.Die();
            cameraDeath.gameObject.SetActive(true);
            uiManager.PlayerDead();
        }
    }
}
