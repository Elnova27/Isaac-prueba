using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int Coins;
    public int Bombs;
    public int Keys;

    public int CoinLimit = 99;
    public int BombLimit = 99;
    public int KeyLimit = 99;

    public void AddCoin(int value)
    {
        Coins += value;
        Coins = Mathf.Clamp(Coins, 0, CoinLimit);
    }
    public void AddBomb(int value)
    {
        Bombs += value;
        Bombs = Mathf.Clamp(Bombs, 0, BombLimit);
    }
    public void AddKey(int value)
    {
        Keys += value;
        Keys = Mathf.Clamp(Keys, 0, KeyLimit);
    }
}
