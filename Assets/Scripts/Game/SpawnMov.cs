using UnityEngine;

public class SpawnMov : MonoBehaviour
{
    [Header("Movimiento Caida")]
    public float speed = 5f;
    public Vector2 moveDirection = Vector2.down;

    [Header("Límite de Destrucción")]
    public float destroyLimitY = -6f;  

    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);

        if (transform.position.y < destroyLimitY)
        {
            Destroy(gameObject);
        }
    }
}