using UnityEngine;

public class OrbeScript : MonoBehaviour
{
    public int valororbe = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
         
            GameManager.instance.SumarOrbe(valororbe);

            Destroy(gameObject);
        }
    }

}
