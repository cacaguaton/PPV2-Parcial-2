using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovimientoSimple : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);

        // Mover el objeto en la dirección calculada
        transform.Translate( movimiento * velocidad * time.deltaTime, Space.World);
    }
}