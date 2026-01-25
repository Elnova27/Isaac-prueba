using UnityEngine;

public class Animation : MonoBehaviour
{
    public Mediador mediator;

    [Header("Referencias")]
    
    public Animator animatorBody;
    public Animator animatorHead;
    public SpriteRenderer spriteRenderer;

    [Header("Estado")]
    public MovementState movementState;
    public int valuee;

    public void Configuration(Mediador mediatorReceived)
    {
        mediator = mediatorReceived;
    }

    public void PlayerMovement(MovementState movementState, int value)
    {
        this.movementState = movementState;
        valuee = value;

        // Dirección limpia: -1, 0 o 1

        switch (movementState)
        {
            case MovementState.Idle:
                animatorBody.SetInteger("Direction", 0);
                animatorHead.SetInteger("Direction", 0);
                break;

            case MovementState.Walk:
                animatorBody.SetInteger("Direction", value);
                animatorHead.SetInteger("Direction", value);
                break;

            case MovementState.Air:
                animatorBody.SetInteger("Direction", value);
                animatorHead.SetInteger("Direction", 0);
                break;
        }
    }
}
