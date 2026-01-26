using UnityEngine;

public class SoulHeart : Pickup
{
    protected override PickupEnum pickupEnum => PickupEnum.RedHeart;

    protected override void GiveReward()
    {
        Player.HealSoulHeart(2);
        //throw new System.NotImplementedException();
        animatorManager.Picking();
    }
    
}
