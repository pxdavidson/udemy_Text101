using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    
    // Define Externals
    [SerializeField] State state;
    TextWriter textWriter;

    // Use this for initialization
    void Start()
    {
        textWriter = FindObjectOfType<TextWriter>();
    }

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
            textWriter.UpdateState(state);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
            textWriter.UpdateState(state);
        }
        else
        {
            // Do nothing
        }
    }
}
