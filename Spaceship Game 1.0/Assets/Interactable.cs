using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public enum Type {Player, Object}
    public int health;

    public Type type;

    int GetHealth()
    {
        return health;
    }
    public void SetHealth(int h)
    {
        health = h;
    }
    public void TakeDamage(int d)
    {
        health -= d;
    }
}
