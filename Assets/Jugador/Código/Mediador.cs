using UnityEngine;

public class Mediador : MonoBehaviour
{
    public RecibirControles recibirControles;
    //---------------------------
    public Vida vida;
    //---------------------------
    public Fisicas fisicas;
    public CharacterController characterController;
    //---------------------------
    public Estadisticas estadisticas;
    //---------------------------
    public Inventory inventory;


    void Start()
    {
        vida.Configuración(this);
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

    public void AddBomb(int value)
    {
        inventory.AddBomb(value);
    }

    public void HealRedHeart(int value)
    {
        
    }

    public bool CanReceiveRedHeart()
    {
        return(vida.CanReceiveRedHeart());
    }

    public void EnviarEjes(float h, float v)
    {
        fisicas.RecibirEjes(h, v);
    }

    public void AddCoin(int value)
    {
        inventory.AddCoin(value);
    }
}
