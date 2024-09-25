using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class SpellCard : Card
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
        gameManagerComponent.spImage.sprite = this.Entity.Design;
        gameManagerComponent.spDescription.text = this.Entity.Description;
        gameManagerComponent.spMana.text = this.Mana.ToString();
    }

}
