using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int damagePower;
    public string itemName;
    private float baseCost;

    void start()
    {
        baseCost = cost;
    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + damagePower;
    }

    public void PurchasedUpgrade()
    {
        if (click.exp >= cost)
        {
            click.exp -= cost;
            count += 1;
            click.damagePerClick += damagePower;
            cost = Mathf.Round(cost*1.5f);
        }
    }

}
