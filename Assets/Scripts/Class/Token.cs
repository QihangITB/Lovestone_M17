using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class Token : Fighter
{
    public int Position;
    public int CurrentDamage;
    public int CurrentHP;
    public CharacterSO Character;

    private GameObject gameManager;
    private GameManager gameManagerComponent;

    public void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        gameManagerComponent = gameManager.GetComponent<GameManager>();
    }

    public void PassInfo()
    {
        gameManagerComponent.tkImage.sprite = this.Character.Design;
        gameManagerComponent.tkDamage.text = this.Character.Damage.ToString();
        gameManagerComponent.tkHealth.text = this.Character.HP.ToString();
    }
}
