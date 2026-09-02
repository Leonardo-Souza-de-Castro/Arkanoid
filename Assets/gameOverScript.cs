using UnityEngine;

public class gameOverScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.collider.CompareTag("Ball")) {
            GameManager.instance.GameOver();
        }
    }

    void Update()
    {
        
    }
}