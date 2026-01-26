using UnityEngine;
using UnityEngine.UIElements;

public class Mediador : MonoBehaviour
{
    public RecibirControles recibirControles;
    //---------------------------
    public Animation animationCharacter;
    //---------------------------
    public Health health;


    //---------------------------
    public Fisicas fisicas;
    public CharacterController characterController;
    //---------------------------
    public Estadisticas estadisticas;
    //---------------------------
    public Inventory inventory;


    void Awake()
    {
        health.Configuration(this);
        recibirControles.Configuration(this);
        fisicas.Configuración(this, characterController);
        animationCharacter.Configuration(this);
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

    public void PlayerMovement(MovementState movementState, int value)
    {
        animationCharacter.PlayerMovement(movementState, value);
    }
    

    public void AddBomb(int value)
    {
        inventory.AddBomb(value);
    }

    public void HealRedHeart(int value)
    {
        health.HealRedHeart(value);
    }
    public void HealSoulHeart(int value)
    {
        health.HealSoulHeart(value);
    }
    public bool CanReceiveRedHeart()
    {
        return health.CanReceiveRedHeart();
    }

    // public bool CanReceiveRedHeart()
    // {
    //     return(health.CanReceiveRedHeart());
    // }

    public void EnviarEjes(float h, float v)
    {
        fisicas.RecibirEjes(h, v);
    }

    public void AddCoin(int value)
    {
        inventory.AddCoin(value);
    }
}
