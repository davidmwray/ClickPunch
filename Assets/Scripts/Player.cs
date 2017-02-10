using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Click click;
    public UnityEngine.UI.Text playerHealthDisplay;
    public UnityEngine.UI.Text playerDefenseDisplay;
    public UnityEngine.UI.Text playerDamageDisplay;
    public UnityEngine.UI.Text playerExpDisplay;
    public float StartingHP = 1f;
    public float HP = 1f;
    public float MaxHP = 100f;
    public float StartingDamage = 1f;
    public float Damage = 1f;
    public int playerDefense;
    public float EXP;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerHealthDisplay.text = "HP: " + (HP) + "/" + MaxHP ;
        playerDamageDisplay.text = "Damage Per Hit: " + Damage;
        playerDefenseDisplay.text = "Defense: " + playerDefense;
        playerExpDisplay.text = "EXP Points: " + EXP;
    }

    public void SetUpAfterDeath(float hp, float damage)
    {
        StartingHP = hp;
        HP = StartingHP;

        Damage = Mathf.Max(1f, damage);
    }

    public void TakeDamage(float damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            HP = 0;
            GameManager.Inst.OnPlayerDeath();
        }
    }
}

