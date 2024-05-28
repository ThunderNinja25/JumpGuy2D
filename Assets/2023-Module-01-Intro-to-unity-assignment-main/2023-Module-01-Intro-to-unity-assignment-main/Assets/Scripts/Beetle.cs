using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beetle : MonoBehaviour
{
    public Character player;
    public UIManager uiManager;
    public Camera cameraDeath;
    
    [SerializeField] private float attackDistance;
    [SerializeField] private float beetleSpeed;

    private Rigidbody2D beetleRB;

    private void Start()
    {
        beetleRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.Die();
            cameraDeath.gameObject.SetActive(true);
            uiManager.PlayerDead();
        }

        if (other.collider.CompareTag("Pipes"))
        {
            beetleRB.transform.Rotate(0,180,0);
            //beetleRB.AddForce(Vector2.right * beetleSpeed * Time.deltaTime);
            
        }
    }

    private void Move()
    { 
        beetleRB.AddForce(Vector2.left * beetleSpeed * Time.deltaTime);
    }
}
