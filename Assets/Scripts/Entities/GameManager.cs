using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Text chMana, chDamage, chHealth, chDescription, tkDamage, tkHealth, pwMana, spMana, spDescription;
    public Image chImage, avImage, tkImage, pwImage, spImage;
    void Awake()
    {
        if (gameManager == null && gameManager != this)
        {
            Destroy(this.gameObject);
        }
        gameManager = this;
    }

}
