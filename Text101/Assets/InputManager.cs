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
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
                textWriter.UpdateState(nextStates[index]);
            }
            else
            {
                // Do nothing
            }
        }
    }
}
