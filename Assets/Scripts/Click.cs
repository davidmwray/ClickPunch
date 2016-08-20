using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour
{
    public Player player;
    public CPU cpu;
    public UnityEngine.UI.Text hpDisplay;
    public UnityEngine.UI.Text damageDisplay;
    public UnityEngine.UI.Text expDisplay;
    public float exp = 0.00f;
    public float damagePerClick = 1.00f;
    public int count = 0;
    public int clickCount = 0;

	void Start ()
    {
	
	}
	
	void Update ()
    {
        if (cpu.cpuHp - player.playerDamage <= -1)
        {
            count++;
            switch (count)
            {
                case 1:
                    cpu.cpuHp = (cpu.cpuHp * 10);
                    damagePerClick = Mathf.Round(damagePerClick * 2);
                    exp = exp + 10;
                    break;
                case 2:
                    cpu.cpuHp = (cpu.cpuHp * 10);
                    damagePerClick = Mathf.Round(damagePerClick * 1.25f);
                    break;
                case 3:
                    cpu.cpuHp = (cpu.cpuHp * 10);
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
        player.playerDamage += damagePerClick;

        clickCount++;

        if (clickCount == 10)
        {
            exp++;
            clickCount = clickCount * 0;
        }
            
            
            
        
    }
}
