using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Click click;
    public UnityEngine.UI.Text playerHealthDisplay;
    public UnityEngine.UI.Text playerDefenseDisplay;
    public UnityEngine.UI.Text playerDamageDisplay;
    public double playerHp = 100;
    public float playerDamage;
    public int playerDefense;
    public int playerExp;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        playerHealthDisplay.text = "HP: " + (playerHp);
        playerDamageDisplay.text = "Damage Per Hit: " + click.damagePerClick;
        playerDefenseDisplay.text = "Defense: " + playerDefense;
	}
}
