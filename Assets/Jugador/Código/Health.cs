using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
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

    //public List<Heart> heartList = new List<Heart>();

    public void AddHeart(Heart heart)
    {
        //heartList.Add(heart);
    }

    public bool CanReceiveRedHeart()
    {
        //for(int i = 0; i > heartList.Count; i++)
        //{
        //    //if(heartList[i].)
        //}

        return(false);
    }
    public void DrawHealth()
    {
        container.Clear();
        for (int i = 2; i < currentHearts; i += 2)
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

        for (int i = 2; i < soulHearts; i += 2)
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
