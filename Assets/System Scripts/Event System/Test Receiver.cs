using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Class Information

// Author: Frank Manford
// Description: 
// Last Updated: 

#endregion

public class TestReceiver : MonoBehaviour
{
    private void Start()
    {
        ModularEventManager.current.AttachMethodToEvent("Test Click", TestMessage);
    }

    private void TestMessage()
    {
        Debug.Log("Test Event Received");
    }
}
