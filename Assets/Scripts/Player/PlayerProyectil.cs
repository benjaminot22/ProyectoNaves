
using UnityEngine;

public class ProyectilPlayer : MonoBehaviour
{
    // Velocidad del proyectil
    [SerializeField] private float velocidad = 10f;

    // Tiempo antes de destruir el proyectil
    [SerializeField] private float tiempoVida = 3f;

    private Rigidbody2D rb2d;

    void Start()
    {
        // Obtenemos el Rigidbody2D
        rb2d = GetComponent<Rigidbody2D>();

        // Movemos el proyectil hacia arriba
        rb2d.linearVelocity = Vector2.up * velocidad;

        // Destruimos el proyectil después del tiempo indicado
        Destroy(gameObject, tiempoVida);
    }
}

