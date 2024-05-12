using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VInspector;

public class ModularEventManager : MonoBehaviour
{
    public static ModularEventManager current;

    [SerializeField] private List<ModularEvent> events;

    private void Awake()
    {
        current = this;
        LoadEvents();
    }

    private void LoadEvents()
    {
        Debug.Log("LoadEvents");

        string[] guids = AssetDatabase.FindAssets("t:ModularEvent", new string[] { "Assets/System Scripts/Event System/Events" });

        foreach (string guid in guids)
        {
            Debug.Log(guid);

            events.Add(AssetDatabase.LoadAssetAtPath<ModularEvent>(AssetDatabase.GUIDToAssetPath(guid)));
        }
    }

    public void TriggerEvent(string eventName)
    {
        if (events.Find(ModularEvent => ModularEvent.name == eventName) != null)
        {
            events.Find(ModularEvent => ModularEvent.name == eventName).Trigger();
        }

        else
        {
            Debug.Log(eventName + " Doesnt Exist");
        }
    }

    public void AttachMethodToEvent(string eventName, Action method)
    {
        if (events.Find(ModularEvent => ModularEvent.name == eventName) != null)
        {
            events.Find(ModularEvent => ModularEvent.name == eventName).AttachMethod(method);
        }

        else
        {
            Debug.Log(eventName + " Doesnt Exist");
        }
    }

    public void DetachMethodFromEvent(string eventName, Action method)
    {
        if (events.Find(ModularEvent => ModularEvent.name == eventName) != null)
        {
            events.Find(ModularEvent => ModularEvent.name == eventName).DetachMethod(method);
        }

        else
        {
            Debug.Log(eventName + " Doesnt Exist");
        }
    }
}
