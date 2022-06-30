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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    void SetHealth(int h)
    {
        health = h;
    }
    void TakeDamage(int d)
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    public void SetHealth(int h)
    {
        health = h;
    }
    public void TakeDamage(int d)
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    {
        health -= d;
    }
}
