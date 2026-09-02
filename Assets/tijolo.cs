using UnityEngine;
using UnityEngine.SceneManagement; 

public class Tijolo : MonoBehaviour
{
    [Header("Sprites de dano (em ordem: normal -> mais rachado)")]
    public Sprite[] spritesRachadura; 

    [Header("Configuração")]
    public int vidas = 3;

    SpriteRenderer sr;
    int vidaAtual;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        vidaAtual = vidas;
    }

    public void LevarDano()
    {
        vidaAtual--;

        if (vidaAtual <= 0)
        {
            GameManager.Score();
            Destroy(gameObject);
            GameObject[] gos = GameObject.FindGameObjectsWithTag("Brick");
            print(gos.Length);
            Scene scene = SceneManager.GetActiveScene();
            if(gos.Length == 0){
                if (scene.name == "arkanoid 2"){
                    GameManager.instance.Win();
                }
            }
        }
        else
        {
            int index = vidas - vidaAtual - 1;
            if (index >= 0 && index < spritesRachadura.Length)
            {
                sr.sprite = spritesRachadura[index];
            }
        }
    }
}