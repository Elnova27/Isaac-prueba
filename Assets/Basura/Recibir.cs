using UnityEngine;

public class Recibir : MonoBehaviour
{
    public Enviar Enviar;

    void Start()
    {
        var (tipo, valor) = Enviar.Obtener();
        print("Objeto: " + tipo + ", Cantidad: " + valor);
    }

    void Update()
    {
        
    }
}
