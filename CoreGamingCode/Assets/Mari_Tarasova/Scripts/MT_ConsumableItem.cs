using UnityEngine;

public class MT_ConsumableItem : MT_ItemClass
{
    private int healthBoost;
    
    public MT_ConsumableItem(string newName, int newId, int newHealthBoost) : base(newName, newId)
    {
        healthBoost = newHealthBoost;
    }

    public MT_ConsumableItem(string newName, int newId, string newDescription, float newWeight, int mewHealthBoost) :
        base(newName, newId, newDescription, newWeight)
    {
        healthBoost = mewHealthBoost;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Debug.Log("Health Boost: " + healthBoost);
    }

    public void Consume()
    {
        Debug.Log("You consume the " + name + " you receive a health boost of " + healthBoost);
    }
}
