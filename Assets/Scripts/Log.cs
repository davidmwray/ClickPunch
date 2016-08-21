using UnityEngine;
using System.Collections;
using System;

public class Log : MonoBehaviour
{
    static Log Inst;
    
    public UnityEngine.UI.Text log;

    // Use this for initialization
    void Awake()
    {
        Inst = this;
    }

    void Start ()
    {
	}

    // Update is called once per frame
    void Update ()
    {
        
    }

    public static void LogEntry(string msg)
    {
        Inst._LogEntry(msg);
    }

    void _LogEntry(string msg)
    {
        var msgWithTime = DateTime.Now.ToString("HH:mm:tt") + "\n" + msg + "\n";
        log.text = msgWithTime + log.text;
    }
}
