using UnityEngine;

public class RedHeart : Pickup
{
    protected override PickupEnum pickupEnum => PickupEnum.RedHeart;

    protected override bool CheckPickup()
    {
        return Player.CanReceiveRedHeart();
    }

    protected override void GiveReward()
    {
        Player.HealRedHeart(2);
        //throw new System.NotImplementedException();
        animatorManager.Picking();
    }
    
}
