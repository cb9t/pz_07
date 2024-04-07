using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor.Search;
using UnityEngine;

public abstract class Person : MonoBehaviour
{
    public string Name
    { get { return _name; } }
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            if (value <= 0)
            {
                _health = 0;
                Debug.Log(message: "Health 0");
            }
            else if (value >= 100)
            {
                _health = 100;
                Debug.Log(message: "Health 100");
            }
        }
    }
    public int DamageValue
    { get { return _damageValue; } }
    private int _health = 100;
    private string _name = "Person";
    private int _damageValue = 30;


    public void Start()
    {
        Debug.Log(message: DamageValue);
        TackeDamage();

    }

    public abstract void TackeDamage();

    
}