using UnityEngine;

public abstract class Heart : MonoBehaviour
{
    public int vidaActual;
    public int vidaMaxima;
    
    //protected abstract HeartEnum heartEnum { get; }
    protected bool Destruible;
/*
    public void Initialize(int Heal)
    {
        vidaActual = Heal;
    }

    public int RecibirDaño(int daño)
    {
        vidaActual -= daño;
        
        if(vidaActual <= 0)
        {
            int sobrante = -vidaActual;
            vidaActual += vidaActual;

            if (Destruible)
                Autodestruir();

            return sobrante;
        }
        return 0;
    }

    public int RecibirCuracion(int curacion)
    {
        vidaActual += curacion;
        
        if(vidaActual > vidaMaxima)
        {
            int sobrante = vidaActual - vidaMaxima;
            vidaActual -= vidaActual - vidaMaxima;
            
            return sobrante;
        }
        return 0;
    }

    protected virtual void Autodestruir()
    {
        print("destruir");
    }*/
}
