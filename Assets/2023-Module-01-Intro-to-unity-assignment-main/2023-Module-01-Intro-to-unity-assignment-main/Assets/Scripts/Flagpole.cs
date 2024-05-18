using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flagpole : MonoBehaviour
{
    [SerializeField] GameObject flag;
    public UIManager uiManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            flag.gameObject.SetActive(true);
            uiManager.NextLevel();
        }
    }
}
