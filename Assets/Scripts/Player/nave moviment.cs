
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    // Componente fisico de la nave
    private Rigidbody2D rb2d;

    // Velocidad de movimiento
    [SerializeField] private float velocidad = 5f;

    // Velocidad constante de ascenso
    [SerializeField] private float velocidadAscenso = 2f;

    // Movimiento horizontal y vertical
    private float movimientoHorizontal;
    private float movimientoVertical;

    void Start()
    {
        // Obtenemos el Rigidbody2D de la nave
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Detectamos las teclas de movimiento
        movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        movimientoVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Creamos el movimiento de la nave
        Vector2 movimiento = new Vector2(
            movimientoHorizontal,
            movimientoVertical
        );

        // Evitamos que la nave sea mas rapida en diagonal
        movimiento = Vector2.ClampMagnitude(movimiento, 1f);

        // Sumamos el ascenso constante
        Vector2 ascenso = Vector2.up * velocidadAscenso;

        // Aplicamos el movimiento usando Rigidbody2D
        rb2d.linearVelocity = (movimiento * velocidad) + ascenso;
    }
}

