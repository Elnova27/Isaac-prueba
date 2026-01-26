using UnityEngine;
using System.Collections;

public enum PickupEnum
{
    Bomb,
    DoubleBomb,
    RedHeart,
    Key,
    
    Penny
}
public abstract class Pickup : MonoBehaviour
{
    public Mediador Player;
    public AnimatorManager animatorManager;
    public bool obtainable = true;

    public int rewardValue = 1;
    protected abstract PickupEnum pickupEnum { get;}
    void Start()
    {
        animatorManager.Appear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
            return;

        Player = other.GetComponent<Mediador>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Player != null && CheckPickup() && obtainable == true)
        {
            GiveReward();
            animatorManager.Picking();
            obtainable = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
            return;

        if (other.GetComponent<Mediador>() == Player)
        Player = null;
    }

    protected virtual bool CheckPickup()
    {
        return true;
    }

    protected abstract void GiveReward();
    public virtual void AlreadyPicked()
    {
        SelfDestroy();
    }
    protected virtual void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
