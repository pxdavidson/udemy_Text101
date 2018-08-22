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

    // Define Variables
    string bodyTextContent;

	// Use this for initialization
	void Start ()
    {
        UpdateText();
        bodyTextComponent.text = bodyTextContent;
	}

    // Call this and pass updated text to it to display
    public void UpdateText()
    {
        bodyTextContent = state.GetStoryText();
    }
}
