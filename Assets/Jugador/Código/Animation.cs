using UnityEngine;

public class Animation : MonoBehaviour
{
    public Mediador mediator;
    public int valuee;
    public Animator animator;
    public MovementState movementState;
    public SpriteRenderer spriteRenderer;
    public void Configuration(Mediador mediatorReceived)
    {
        mediator = mediatorReceived;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerMovement(MovementState movementState, int value)
    {   
        this.movementState = movementState;
        valuee = value;
        switch (movementState)
        {
            case MovementState.Idle:
                animator.SetInteger("Direction", 0);
                spriteRenderer.flipX = false;
                break;

            case MovementState.Walk:

                switch (value)
                {
                    case 1:
                        animator.SetInteger("Direction", value);
                        break;

                    case -1:
                        animator.SetInteger("Direction", -value);
                        spriteRenderer.flipX = true;
                        break;
                        
                    case 2:
                        animator.SetInteger("Direction", value);

                        break;
                    case -2:
                        animator.SetInteger("Direction", -value);
                        break;
                }     

                break;

            case MovementState.Air:
                // lógica cuando camina
                break;
        }

    }
}
