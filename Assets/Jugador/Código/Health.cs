using UnityEngine;
using System.Collections.Generic;

public enum HeartEnum
{
    RedHeart = 1,
    HalfRedHeart = 2,
    SoulHeart = 3

}

public class Health : MonoBehaviour
{

    public int maxHearts = 6;
    public int currentHearts = 4;

    public GameObject heartbarUI;

    private Mediador mediador;
    
    public void Configuration(Mediador mediadorRecibido)
    {
        mediador = mediadorRecibido;
    }

    //public List<Heart> heartList = new List<Heart>();

    public void AddHeart(Heart heart)
    {
        //heartList.Add(heart);
    }

    public bool CanReceiveRedHeart()
    {
        //for(int i = 0; i > heartList.Count; i++)
        //{
        //    //if(heartList[i].)
        //}

        return(false);
    }

}
