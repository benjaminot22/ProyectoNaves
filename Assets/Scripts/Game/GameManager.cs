using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UIManager uimanager;
<<<<<<< Updated upstream
    public int vidas = 3;

    [Header("Gemas")]
    public int gemas = 0;
    public TextMeshProUGUI textogemas;

    [Header("UI Game Over")]
    public GameObject panelGameOver;

    public object GemasTotales { get; internal set; }
=======
    public int puntos;

    [Header("Orbes")]
    public int orbes = 0;
    public TextMeshProUGUI textorbes;

    public object OrbesTotales { get; internal set; }
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
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

=======
        CargarOrbes();
        ActualizarOrbesUI();

    }

    public void SumarOrbe(int cantidad)
    {
        orbes += cantidad;
        ActualizarOrbesUI();
        GuardarOrbes();
    }

    void ActualizarOrbesUI()
    {
        if (textorbes != null)
            textorbes.text = "x" + orbes.ToString();
    }

    void GuardarOrbes()
    {
        PlayerPrefs.SetInt("Orbes", orbes);
        PlayerPrefs.Save();
    }

    void CargarOrbes()
    {
        orbes = PlayerPrefs.GetInt("Orbes", 0);
    }


   

>>>>>>> Stashed changes
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


<<<<<<< Updated upstream


}
=======
}
>>>>>>> Stashed changes
