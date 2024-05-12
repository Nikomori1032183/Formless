using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSender : MonoBehaviour
{
    private void Start()
    {
        
    }

    public void ButtonClick()
    {
        ModularEventManager.current.TriggerEvent("Test Click");
    }
}
