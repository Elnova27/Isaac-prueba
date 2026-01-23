using UnityEngine;
using System.Collections;

public enum PickupEnum
{
    Bomb,
    DoubleBomb,
    Heart,
    Key,
    
    Penny
}
public abstract class Pickup : MonoBehaviour
{
    public Mediador Player;
    public bool obtainable = true;

    protected abstract PickupEnum pickupEnum { get; }
    void Start()
    {
        
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

    protected virtual void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
