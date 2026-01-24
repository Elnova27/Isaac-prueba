using UnityEngine;

public class Bomb : Pickup
{
    protected override PickupEnum pickupEnum => PickupEnum.Bomb;

    protected override void GiveReward()
    {
        Player.AddBomb(1);
        //throw new System.NotImplementedException();
        SelfDestroy();
    }
    
}
