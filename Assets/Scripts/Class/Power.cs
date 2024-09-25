using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Power : Invocable
{
    public EntitySO Entity;
    private GameObject gameManager;
    private GameManager gameManagerComponent;

    public void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        gameManagerComponent = gameManager.GetComponent<GameManager>();
    }

    public void PassInfo()
    {
        gameManagerComponent.pwImage.sprite = this.Entity.Design;
        gameManagerComponent.pwMana.text = this.Mana.ToString();
    }
    public void HeroPower() { }

}
