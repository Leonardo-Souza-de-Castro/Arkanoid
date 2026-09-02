using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class initManager : MonoBehaviour
{
    public static initManager instance;

    [Header("UI Init Game")]
    public Button btnSair;
    public Button btnIniciar;

    void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (btnSair != null)
        {
            btnSair.onClick.AddListener(Fechar);
            
        }
        if (btnIniciar != null)
        {
            btnIniciar.onClick.AddListener(Iniciar);
            
        }
    }

    public void Iniciar(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("arkanoid");
    }

    public void Fechar(){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
