using UnityEngine;

public class MT_TestItemClassScript : MonoBehaviour
{
    private MT_ItemClass rock, hat;
    private MT_ConsumableItem potion, drink;
    private MT_Weapon sword;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rock = new MT_ItemClass("A Rock", 0, "This is one boring rock", 1.2f);
        sword = new MT_Weapon("Rapier", 1, "Sharp but flimsy!", 0.8f, 35);
        potion = new MT_ConsumableItem("Green Potion", 2, "I really wouldn't", 0.2f, -50);
        hat = new MT_ItemClass("Beret", 3, "A simple beret with a green logo", 0.1f);
        drink = new MT_ConsumableItem("Water", 4, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            potion.DisplayInfo();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            potion.Consume();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            sword.Attack();
        }
    }
}
