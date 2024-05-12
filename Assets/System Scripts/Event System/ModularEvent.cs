using System;
using UnityEngine;
using VInspector;

[CreateAssetMenu]
public class ModularEvent : ScriptableObject
{
    public event Action onEvent;

    [SerializeField] private bool debug;

    public void Trigger()
    {
        if (onEvent != null)
        {
            DebugMessage(name + " Triggered");
            onEvent();
        }

        else
        {
            DebugMessage("Nothing Attached To " + name + " Event");
        }
    }

    public void AttachMethod(Action method)
    {
        onEvent += method;
    }

    public void DetachMethod(Action method)
    {
        onEvent -= method;
    }

    public void DebugMessage(string message)
    {
        if (debug)
        {
            Debug.Log(message);
        }
    }
}
