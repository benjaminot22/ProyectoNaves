
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Prefab del proyectil
    [SerializeField] private GameObject bulletPrefab;

    // Punto desde donde dispara la nave
    [SerializeField] private Transform firePoint;

    // Tiempo entre disparos
    [SerializeField] private float tiempoEntreDisparos = 0.3f;

    // Guarda el tiempo del siguiente disparo
    private float siguienteDisparo = 0f;

    void Update()
    {
        // Disparamos al presionar Space
        if (Input.GetKeyDown(KeyCode.Space) &&
            Time.time >= siguienteDisparo)
        {
            Shoot();

            // Calculamos el siguiente disparo
            siguienteDisparo = Time.time + tiempoEntreDisparos;
        }
    }

    void Shoot()
    {
        // Creamos el proyectil en el FirePoint
        Instantiate(
            bulletPrefab,
            firePoint.position,
            firePoint.rotation
        );
    }
}

