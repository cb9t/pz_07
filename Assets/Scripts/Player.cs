using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
    public override void TackeDamage()
    {
        Debug.Log(message: $"My name is {Name}: After hitting with forc: {DamageValue} I have: health {Health - DamageValue}");
    }
}
