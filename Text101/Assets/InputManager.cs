using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    
    // Define Externals
    [SerializeField] State state;
    TextWriter textWriter;
	
	// Update is called once per frame
	void Update ()
    {
        ManageStates();
	}

    public void ManageStates()
    {
        var nextStates = state.GetNextStates();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            textWriter.UpdateState(nextStates[0]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
            textWriter.UpdateState(nextStates[1]);
        }
        else
        {
            // Do nothing
        }
    }
}
