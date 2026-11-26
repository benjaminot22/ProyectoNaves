using UnityEngine;

public class EnemyStaticScript : MonoBehaviour
{
    public GameObject GameOver;

    private void Start()
    {
        Time.timeScale = 1f;
        GameOver.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player") == true)
        {
            Time.timeScale = 0f;
            GameOver.SetActive(true);
        }
    }

}