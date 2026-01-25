using UnityEngine;

public class Key : Pickup
{
    protected override PickupEnum pickupEnum => PickupEnum.Key;

    protected override void GiveReward()
    {
        //Player.AddKey(1);
        //throw new System.NotImplementedException();
        SelfDestroy();
    }
    
}
