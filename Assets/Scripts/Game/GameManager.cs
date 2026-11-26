using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UIManager uimanager;
    public int vidas = 3;

    [Header("Gemas")]
    public int gemas = 0;
    public TextMeshProUGUI textogemas;

    [Header("UI Game Over")]
    public GameObject panelGameOver;

    public object GemasTotales { get; internal set; }

    private void Start()
    {
        Time.timeScale = 1f;
        if (uimanager == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }


    }

    void start()
    {
        CargarMonedas();
        ActualizarMonedasUI();

    }

    public void SumarGema(int cantidad)
    {
        gemas += cantidad;
        ActualizarMonedasUI();
        GuardarMonedas();
    }

    void ActualizarMonedasUI()
    {
        if (textogemas != null)
            textogemas.text = "x" + gemas.ToString();
    }

    void GuardarMonedas()
    {
        PlayerPrefs.SetInt("Gemas", gemas);
        PlayerPrefs.Save();
    }

    void CargarMonedas()
    {
        gemas = PlayerPrefs.GetInt("Gemas", 0);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }




}