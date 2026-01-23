using UnityEngine;

public class SoulHeartContainer : Heart
{
    private void Awake()
    {
        vidaMaxima = 2;
        vidaActual = vidaMaxima;
        Destruible = true;
    }
    protected override HeartEnum heartEnum => HeartEnum.SoulHeart;
}