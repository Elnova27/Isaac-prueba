using UnityEngine;

public class Fisicas : MonoBehaviour
{
    private Mediador mediador;
    private CharacterController characterController;
    
    public float hActual;
    public float vActual;
    public float suavizado;
    public float multiplicadorVelocidadInterno;

    public void Configuración(Mediador mediadorRecibido, CharacterController characterControllerMediador)
    {
        mediador = mediadorRecibido;
        characterController = characterControllerMediador;
    }
    public void RecibirEjes(float h, float v)
    {
        //if(h != 0 && hActual != 0 && Mathf.Sign(h) != Mathf.Sign(hActual)) hActual = 0;
        //if(v != 0 && vActual != 0 && Mathf.Sign(v) != Mathf.Sign(vActual)) vActual = 0;

        hActual = Mathf.Lerp(hActual, h, suavizado * Time.deltaTime);
        vActual = Mathf.Lerp(vActual, v, suavizado * Time.deltaTime);
        
        if (Mathf.Abs(hActual) < 0.0001f) hActual = 0f;
        if (Mathf.Abs(vActual) < 0.0001f) vActual = 0f;

        Vector3 movimiento = new Vector3(hActual, 0, vActual);
        characterController.Move(movimiento * mediador.ConsultarVelocidad() * multiplicadorVelocidadInterno * Time.deltaTime);
    }
}


