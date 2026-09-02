using UnityEngine;

public class moveBallfase2 : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float velocidade;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.linearVelocity = Vector2.up * velocidade;
    }

    void OnCollisionEnter2D (Collision2D coll) {
        if(coll.collider.CompareTag("Player")){
            float xAxis = (transform.position.x - coll.transform.position.x) / coll.collider.bounds.size.x;
            Vector2 direction = new Vector2(xAxis, 1).normalized;
            rb2d.linearVelocity = direction * velocidade;
        }

        if (coll.gameObject.tag == "Brick"){
            Tijolo tijolo = coll.gameObject.GetComponent<Tijolo>();
            if (tijolo != null)
            {
                tijolo.LevarDano();
            }
        }
    }

    void ResetBall(){
        rb2d.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame(){
        ResetBall();
    }

    void Update()
    {
        
    }
}