using UnityEngine;

public class Coin : Pickup
{
    protected override PickupEnum pickupEnum => PickupEnum.Penny;

    protected override void GiveReward()
    {
        Player.AddCoin(rewardValue);
        //throw new System.NotImplementedException();
        SelfDestroy();
    }
    
}
