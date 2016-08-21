using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class Click : MonoBehaviour
{
    public Player player;
    public CPU cpu;
    public UnityEngine.UI.Text hpDisplay;
    public UnityEngine.UI.Text damageDisplay;
    public UnityEngine.UI.Text expDisplay;
    public int clickCount = 0;
    bool debug = false;

    public event EventHandler OnClick;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            debug =! debug;
        }
    }

    public void Clicked()
    {
        
        var damage = player.Damage;
        if (debug)
        {
            damage = .25f *cpu.StartingHP;
        }
        cpu.TakeDamage(damage);
        
        clickCount++;

        if (clickCount == 10)
        {
            player.EXP++;
            clickCount = clickCount * 0;

            Log.LogEntry("You've gained 1 Exp Point.");
        }

        if (OnClick != null)
        {
            OnClick(this, EventArgs.Empty);
        }


    }
}

