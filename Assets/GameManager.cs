using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static int PlayerScore1 = 0;
    GameObject theBall;

    [Header("UI Game Over")]
    public GameObject painelGameOver;
    public Image fundoVermelho;
    public TMP_Text textoGameOver;
    public Button btnReiniciar;
    
    [Header("UI Game Win")]
    public GameObject painelGameWin;
    public Image fundoVerde;
    public TMP_Text textoGameWin;
    public Button btnReiniciar2;

    [Header("UI Game Score")]
    public GameObject painelGameScore;
    public TMP_Text textoGameScore;

    bool gameAcabou = false;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
        painelGameOver.SetActive(false);
        painelGameWin.SetActive(false);

        if (btnReiniciar != null)
        {
            btnReiniciar.onClick.AddListener(ReiniciarJogo);
            
        }
        if (btnReiniciar2 != null)
        {
            btnReiniciar2.onClick.AddListener(ReiniciarJogo);
            
        }

        if (textoGameScore != null)
        {
            textoGameScore.text = "Score: " + PlayerScore1;
        }
    }

    public static void Score()
    {
        PlayerScore1 += 5;
        instance.textoGameScore.text = "Score: " + PlayerScore1;
    }

    public void GameOver()
    {
        if (gameAcabou) return;
        gameAcabou = true;

        painelGameOver.SetActive(true);
        fundoVermelho.color = new Color(1f, 0f, 0f, 0.5f);
        textoGameOver.text = "GAME OVER";

        Time.timeScale = 0f;
    }



    public void ReiniciarJogo()
    {
        Scene scene = SceneManager.GetActiveScene();
        Time.timeScale = 1f;
        gameAcabou = false;
        PlayerScore1 = 0;
        SceneManager.LoadScene("arkanoid");
    }

    public void Win(){
        if (gameAcabou) return;
        gameAcabou = true;

        painelGameWin.SetActive(true);
        fundoVerde.color = new Color(0f, 1f, 0f, 0.5f);
        textoGameWin.text = "Parabéns você venceu!! \n Sua pontuação é de : " + PlayerScore1;

        Time.timeScale = 0f;
    }

    void Update()
    {

    }
}