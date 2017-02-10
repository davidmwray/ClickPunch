using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour
{

    public Click click;
    public Player player;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int damagePower;
    public string itemName;
    public int UpgradeCount = 0;

    void start()
    {

    }

    void Update()
    {
        if (UpgradeCount == 10)
        {
            itemInfo.text = "MAXED OUT";
        }
        else
        {
            itemInfo.text = itemName + "\nDamage +" + damagePower + "\nCost: " + cost + " EXP";
        }
    }

    public void PurchasedUpgrade()
    {
        if (player.EXP >= cost && UpgradeCount < 10)
        {
            player.EXP -= cost;
            UpgradeCount++;
            player.Damage += damagePower;
            cost = Mathf.Round(cost * 1.5f);
        }
    }

}

