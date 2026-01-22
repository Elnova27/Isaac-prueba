using UnityEngine;
using UnityEngine.InputSystem;

public class RecibirControles : MonoBehaviour
{
    private Mediador mediador;

    public InputAction Movimiento = null;
    public InputAction Bomba = null;
    public InputAction Objeto = null;
    public InputAction Consumible = null;
    public InputAction Alternar = null;
    public InputAction Mapa = null;

    public void Configuración(Mediador mediadorRecibido)
    {
        mediador = mediadorRecibido;
    }

    private void OnEnable()
    {
        Movimiento.Enable();
        Bomba.Enable();
        Objeto.Enable();
        Consumible.Enable();
        Alternar.Enable();
        Mapa.Enable();
    }

    private void OnDisable()
    {
        Movimiento.Disable();
        Bomba.Disable();
        Objeto.Disable();
        Consumible.Disable();
        Alternar.Disable();
        Mapa.Disable();
    }

    void Update()
    {
        DetectarEjes();
        DetectarTeclas();
    }

    void DetectarEjes()
    {
        Vector2 ejes = Movimiento.ReadValue<Vector2>();
        Debug.Log(ejes);
        mediador.EnviarEjes(ejes.x, ejes.y);
    }
    
    void DetectarTeclas()
    {
        if (Bomba.WasPressedThisFrame()) mediador.TeclaBomba();
        
    }
}

