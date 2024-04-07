using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Person
{
    public override void TackeDamage()
    {
        Debug.Log(message: $"I, the mighty dragon, have lost: {DamageValue} hit points from a hunter's shot.");
    }
}    

