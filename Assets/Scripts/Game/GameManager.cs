using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UIManager uimanager;
    public int puntos;

    [Header("Orbes")]
    public int orbes = 0;
    public TextMeshProUGUI textorbes;

    public object OrbesTotales { get; internal set; }

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
        CargarOrbes();
        ActualizarOrbesUI();

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
        CargarOrbes();
        ActualizarOrbesUI();

    }

    public void SumarOrbe(int cantidad)
    {
        orbes += cantidad;
        ActualizarOrbesUI();
        GuardarOrbes();
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
