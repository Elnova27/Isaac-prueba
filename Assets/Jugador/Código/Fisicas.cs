using UnityEngine;

public enum MovementState
    {
        Idle,
        Walk,
        Air
    }

public class Fisicas : MonoBehaviour
{
    private Mediador mediador;
    private CharacterController characterController;
    
    public float hActual;
    public float vActual;
    public float suavizado;
    public float threshold = 0.0001f;
    public float animThreshold = 0;
    public float multiplicadorVelocidadInterno;

    public MovementState movementState;

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
        
        if (Mathf.Abs(hActual) < threshold) hActual = 0f;
        if (Mathf.Abs(vActual) < threshold) vActual = 0f;

        Vector3 movimiento = new Vector3(hActual, 0, vActual);
        characterController.Move(movimiento * mediador.ConsultarVelocidad() * multiplicadorVelocidadInterno * Time.deltaTime);

        CalculateState();

    }

    public void CalculateState()
    {
        if (hActual != 0)
        {
            if (hActual > animThreshold)
            {
                mediador.PlayerMovement(MovementState.Walk, 1);
            }
            else if(hActual < -animThreshold)
            {
                mediador.PlayerMovement(MovementState.Walk, -1);
            }
            
        }

        if (vActual != 0)
        {
            if (vActual > animThreshold)
            {
                mediador.PlayerMovement(MovementState.Walk, 2);
            }
            else if(vActual < -animThreshold)
            {
                mediador.PlayerMovement(MovementState.Walk, -2);
            }
            
        }

        if(vActual < animThreshold &&  vActual > -animThreshold  && hActual < animThreshold &&  hActual > -animThreshold) mediador.PlayerMovement(MovementState.Idle, 0);
    }
}


