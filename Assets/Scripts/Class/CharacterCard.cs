using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public abstract class CharacterCard : Card
{
    public CharacterSO Character;
    private GameObject gameManager;
    private GameManager gameManagerComponent;

    public void Invoke(Token token) { }

    public void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        gameManagerComponent = gameManager.GetComponent<GameManager>();
    }

    public void PassInfo()
    {
        gameManagerComponent.chImage.sprite = this.Character.Design;
        gameManagerComponent.chDescription.text = this.Character.Description;
        gameManagerComponent.chHealth.text = this.Character.HP.ToString();
        gameManagerComponent.chDamage.text = this.Character.Damage.ToString();
        gameManagerComponent.chMana.text = this.Mana.ToString();
    }



}
