using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{
    // Define externals
    [SerializeField] Text bodyTextComponent;
    [SerializeField] State state;

	// Use this for initialization
	void Start ()
    {
        UpdateText();
	}

    // Call this and pass updated text to it to display
    void UpdateText()
    {
        bodyTextComponent.text = state.GetStoryText();
    }

    public void UpdateState(State newState)
    {
        Debug.Log("UpdateState");
        state = newState;
        UpdateText();
    }
}
