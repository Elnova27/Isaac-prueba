using UnityEngine;

public class RedHeart : Heart
{
    private void Awake()
    {
        vidaMaxima = 2;
        vidaActual = vidaMaxima;
        Destruible = false;
    }
    protected override HeartEnum heartEnum => HeartEnum.RedHeart;
}