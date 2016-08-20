using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text hpDisplay;
    public UnityEngine.UI.Text damageDisplay;
    public UnityEngine.UI.Text expDisplay;
    public int health = 100;
    public double damage = 0;
    public float exp = 0.00f;
    public float damagePerClick = 10.00f;
    public int count = 0;
    public int clickCount = 0;

	void Start () {
	
	}
	
	void Update () {
        hpDisplay.text = "Health: " + (health - damage);
        damageDisplay.text = "Damage: " + damagePerClick;
        expDisplay.text = "Exp Points: " + exp;

        if (health - damage <= -1)
        {
            count++;
            health += 100;
            switch (count)
            {
                case 1:
                    health = (health * 10);
                    damagePerClick = Mathf.Round(damagePerClick * 2);
                    exp = exp + 10;
                    break;
                case 2:
                    health = (health * 10);
                    damagePerClick = Mathf.Round(damagePerClick * 1.25f);
                    break;
                case 3:
                    health = (health * 10);
                    damagePerClick = Mathf.Round(damagePerClick * 1.25f);
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                default:
                    print("you Win");
                    break;
            }

        }
    }

    public void Clicked()
    {
        damage += damagePerClick;

        clickCount++;

        if (clickCount == 10)
        {
            exp++;
            clickCount = clickCount * 0;
        }
            
            
            
        
    }
}
