using UnityEngine;

public class EnemyHorizontalScript : MonoBehaviour
{
    public float velocidad = 2f;
    private int direccion = -1;
    public GameObject GameOver;

    private void Start()
    {
        Time.timeScale = 1f;
        GameOver.SetActive(false);
    }

    void Update()
    {

        transform.Translate(new Vector2(direccion * velocidad * Time.deltaTime, 0));
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player") == false)
        {

            direccion = direccion * -1;
            if (direccion > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (direccion < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        else
        {
            Time.timeScale = 0f;
            GameOver.SetActive (true);
        }




    }
}