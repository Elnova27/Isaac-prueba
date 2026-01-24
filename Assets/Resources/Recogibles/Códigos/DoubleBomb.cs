using UnityEngine;

public class DoubleBomb : Pickup
{
    protected override PickupEnum pickupEnum => PickupEnum.DoubleBomb;

    protected override void GiveReward()
    {
        Player.AddBomb(2);
        //throw new System.NotImplementedException();
        SelfDestroy();
    }
    
}
