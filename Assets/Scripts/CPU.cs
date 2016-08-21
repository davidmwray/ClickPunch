using UnityEngine;
using System.Collections;
using Random = System.Random;

public class CPU : MonoBehaviour
{

    public Click click;
    public Player player;
    public UnityEngine.UI.Text cpuHealthDisplay;
    public UnityEngine.UI.Text cpuDefenseDisplay;
    public UnityEngine.UI.Text cpuDamageDisplay;
    public int cpuHp = 100;
    public double cpuDamage = 5.00f;
    public int cpuDefense;
    public Random rng = new Random();
    public float attackTimer = 10.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cpuHealthDisplay.text = "CPU HP: " + (cpuHp - player.playerDamage);
        //cpuDamageDisplay.text = "CPU Damage Per Hit: " + click.damagePerClick;
        //cpuDefenseDisplay.text = "CPU Defense: " + cpuDefense;

        attackTimer -= Time.deltaTime;
        var time = System.DateTime.Now;

        if (attackTimer <= 0f)
        {
            player.playerHp -= cpuDamage;
            click.log.text = time.ToString("HH:mm:ss:tt") + "\n-5 HP" + click.log.text;
            attackTimer = rng.Next(1, 11);
        }

    }
}

