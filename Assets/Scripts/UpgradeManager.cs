﻿using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour
{

    public Click click;
    public Player player;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int damagePower;
    public string itemName;

    void start()
    {

    }

    void Update()
    {
        itemInfo.text = itemName + "\nDamage +" + damagePower + "\nCost: " + cost + " EXP";
    }

    public void PurchasedUpgrade()
    {
        if (player.playerExp >= cost)
        {
            player.playerExp -= cost;
            count += 1;
            click.damagePerClick += damagePower;
            cost = Mathf.Round(cost * 1.5f);
        }
    }

}

