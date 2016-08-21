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
    public float StartingHP = 1f;
    public float HP = 1f;
    public float StartingDamage = 5f;
    public float Damage = 5f;
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
        cpuHealthDisplay.text = "CPU HP: " + (HP);
        //cpuDamageDisplay.text = "CPU Damage Per Hit: " + click.damagePerClick;
        //cpuDefenseDisplay.text = "CPU Defense: " + cpuDefense;

        attackTimer -= Time.deltaTime;
        var time = System.DateTime.Now;

        if (attackTimer <= 0f)
        {
            var damage = Damage;
            player.TakeDamage(damage);
            Log.LogEntry("You got punched, causing " + Damage + " damage.");
            attackTimer = rng.Next(1, 11);
        }

    }

    public void SetUpNextOpponent(float hp, float damage)
    {
        StartingHP = hp;
        HP = StartingHP;

        StartingDamage = damage;
        Damage = StartingDamage;
    }

    public void TakeDamage(float damage)
    {
        HP -= damage;
        Log.LogEntry("Thew a punch, causing " + damage + " damage.");
        if (HP <= 0)
        {
            HP = 0;
            GameManager.Inst.OnCPUDeath();
        }
    }
}

