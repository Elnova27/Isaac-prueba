using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
    public int maxHealth = 24;
    public int maxHearts = 6;
    public int currentHearts = 4;
    public int soulHearts = 0;
    public GameObject healthbarUI;

    private Mediador mediador;
    private VisualElement container;

    [SerializeField] private VisualTreeAsset heartFullTemplate;
    [SerializeField] private VisualTreeAsset heartHalfTemplate;
    [SerializeField] private VisualTreeAsset heartEmptyTemplate;
    [SerializeField] private VisualTreeAsset heartSoulTemplate;
    [SerializeField] private VisualTreeAsset heartSoulHalfTemplate;
    
    
    public void Configuration(Mediador mediadorRecibido)
    {
        mediador = mediadorRecibido;
        var root = healthbarUI.GetComponent<UIDocument>().rootVisualElement;
        container = root.Q<VisualElement>("HealthBar");
        DrawHealth();
    }

    public void HealRedHeart(int amount)
    {
        currentHearts += amount;
        if (currentHearts > maxHearts)
        {
            currentHearts = maxHearts;
        }
        DrawHealth();
    }

    public void HealSoulHeart(int amount)
    {
        soulHearts += amount;
        DrawHealth();
    }

    public void Damage(int damage)
    {
        if (soulHearts > 0)
        {
            int damageToSoul = Mathf.Min(damage, soulHearts);
            soulHearts -= damageToSoul;
            damage -= damageToSoul;
        }

        if (damage > 0)
        {
            currentHearts -= damage;
            if (currentHearts < 0)
            {
                currentHearts = 0;
            }
        }
        DrawHealth();
    }

    // public void AddHeart(Heart heart)
    // {
    //     //heartList.Add(heart);
    // }

    public bool CanReceiveRedHeart()
    {
        return currentHearts < maxHearts;
    }
    
    public void DrawHealth()
    {
        container.Clear();
        for (int i = 2; i <= currentHearts; i += 2)
        {
            VisualElement heart = heartFullTemplate.Instantiate();
            container.Add(heart);
        }

        if (currentHearts % 2 != 0)
        {
            VisualElement halfHeart = heartHalfTemplate.Instantiate();
            container.Add(halfHeart);
        }

        for (int i = currentHearts + 1; i < maxHearts; i += 2)
        {
            VisualElement emptyHeart = heartEmptyTemplate.Instantiate();
            container.Add(emptyHeart);
        }

        for (int i = 2; i <= soulHearts; i += 2)
        {
            VisualElement soulHeart = heartSoulTemplate.Instantiate();
            container.Add(soulHeart);
        }

        for (int i = 0; i < soulHearts % 2; i++)
        {
            VisualElement halfSoulHeart = heartSoulHalfTemplate.Instantiate();
            container.Add(halfSoulHeart);
        }
    }
}
