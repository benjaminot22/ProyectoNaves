<<<<<<< Updated upstream
=======
using TMPro;
>>>>>>> Stashed changes
using UnityEngine;

public class UIManager : MonoBehaviour
{
<<<<<<< Updated upstream
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
=======
    public TextMeshProUGUI textorbes;

  
    void Update()
    {
        if (GameManager.instance != null)
        {
            textorbes.text = "X" + GameManager.instance.puntos;
        }


    }

>>>>>>> Stashed changes
}
