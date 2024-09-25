using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fighter : MonoBehaviour
{
    public int Damage;
    public int HP;
    public int Team;

    public void Attack(Fighter fighter) { }

}
