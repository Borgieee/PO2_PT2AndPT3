using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCStats
{
    [SerializeField] private Mercenary mercenary;

    public void Start()
    {
        Debug.Log("Goblin Health: " + NPCHealth);
        Debug.Log("Mercenary Charges at Goblin!");
        Debug.Log("Archer Attacks Goblin: " + mercenary.NPCAttack);
        NPCHealth -= mercenary.NPCAttack;
        Debug.Log("Goblin Health: " + NPCHealth);
    }
}
