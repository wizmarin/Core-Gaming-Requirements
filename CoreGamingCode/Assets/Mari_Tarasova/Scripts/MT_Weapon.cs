using UnityEngine;

public class MT_Weapon : MT_ItemClass
{
    private int damage;
    
    public MT_Weapon(string newName, int newId, string newDescription, float newWeight, int newDamage) : base(newName, newId, newDescription, newWeight)
    {
        damage = newDamage;
    }

    public MT_Weapon(string newName, int newId, int newDamage) : base(newName, newId)
    {
        damage = newDamage;
    }

    public void Attack()
    {
        Debug.Log("You attack with the " + name + " and do " + damage + " damage");
    }
}
