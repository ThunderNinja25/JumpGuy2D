using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IBlock : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private Collision2D rightCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && coin != null)
        {
            coin.gameObject.SetActive(true);
            coin = null;
        }
    }
}
