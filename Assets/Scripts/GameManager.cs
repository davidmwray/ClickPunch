using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Inst;
    public Player player;
    public CPU cpu;
    public Click click;
    public int EnemyCount = 0;
    
    // Use this for initialization
    void Awake ()
    {
        Inst = this;
	}
	
    void Start()
    {
        cpu.SetUpNextOpponent(100f, 5f);
        player.SetUpAfterDeath(100f, 1f);
    }
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void OnCPUDeath()
    {
        EnemyCount++;
        cpu.SetUpNextOpponent (cpu.StartingHP * 10, cpu.StartingDamage *3);
        Log.LogEntry("You did it!");
        player.EXP = player.EXP + 10;
        player.Damage = Mathf.Round(player.Damage * 1.2f);
    }

    public void OnPlayerDeath()
    {

        player.SetUpAfterDeath(Mathf.Floor(player.StartingHP * .9f), Mathf.Floor(player.Damage * .9f));
        Log.LogEntry("Shit! Gotta get up and try harder.");
        player.EXP = Mathf.Floor(player.EXP *.9f);
    }
}
