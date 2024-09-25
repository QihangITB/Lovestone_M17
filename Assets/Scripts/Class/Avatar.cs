using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class Avatar : Fighter
{
    public Power Power;
    public int Armor;
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
        gameManagerComponent.avImage.sprite = this.Entity.Design;
    }
    public void Interact() { }
}
