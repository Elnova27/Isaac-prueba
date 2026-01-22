using UnityEngine;

public class Enviar
{
    public TipoObjetos Objetos;
    public int Valor;

    public (TipoObjetos Objetos, int Valor) Obtener()
    {
        return (Objetos, Valor);
    }
}
