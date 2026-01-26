using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public Pickup pickup;
    

    public void Appear()
    {
        animator.SetInteger("State", 1);
    }

    public void Picking()
    {
        animator.SetInteger("State", 2);
    }

    public void EndPickingAnimation()
    {
        pickup.AlreadyPicked();
    }

    


}
