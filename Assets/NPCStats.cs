using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCStats : MonoBehaviour
{
    [SerializeField] protected int NPCHealth;
    [SerializeField] public int NPCAttack;
    [SerializeField] protected int NPCDefence;
    [SerializeField] protected float NPCSpeed;
}
