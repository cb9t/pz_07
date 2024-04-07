using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
    public int Experiance
    {
        get { return _experiance; }
    }
    private int _experiance;

    public override void ShowStat()
    {
        Debug.Log(message: $"Name: {Name}. Experiance: {Experiance}");
    }
}
