using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Entity",menuName ="ScriptableObject/Entity")]
public class EntitySO : ScriptableObject
{
    public string Name;
    public Sprite Design;
    public string Description;

}
