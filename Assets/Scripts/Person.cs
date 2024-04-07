using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Person : MonoBehaviour
{
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
    public string Name
    {
        get { return _name; }
    }

    private string _name = "Person";
    private int _health;
    
}