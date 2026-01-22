using UnityEngine;

public class Mediador : MonoBehaviour
{
    public RecibirControles recibirControles;
    //---------------------------
    public Fisicas fisicas;
    public CharacterController characterController;
    //---------------------------
    public Estadisticas estadisticas;


    void Start()
    {
        recibirControles.Configuración(this);
        fisicas.Configuración(this, characterController);
    }

    void Update()
    {
        
    }

    public void TeclaBomba()
    {
        
    }

    public float ConsultarVelocidad()
    {
        return(estadisticas.ConsultaVelocidad());
    }

    public void EnviarEjes(float h, float v)
    {
        fisicas.RecibirEjes(h, v);
    }

}
