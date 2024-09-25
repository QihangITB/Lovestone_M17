using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Fireball : SpellCard, IEffect
{
    public void Start()
    {
        base.PassInfo();
    }

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Effect();
        }
    }

    public void Effect()
    {
        Debug.Log("IM FIREBALL");
    }
}
