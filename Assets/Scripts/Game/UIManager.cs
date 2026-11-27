using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textorbes;

  
    void Update()
    {
        if (GameManager.instance != null)
        {
            textorbes.text = "X" + GameManager.instance.puntos;
        }

    }


}
