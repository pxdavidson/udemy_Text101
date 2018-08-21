using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{

    // Define externals
    [SerializeField] Text bodyTextComponent;

    // Define Variables
    string bodyTextContent;

	// Use this for initialization
	void Start ()
    {
        SetIntroText();
        bodyTextComponent.text = bodyTextContent;
	}

    // Sets the introduction text
    void SetIntroText()
    {
        bodyTextContent = "Hello World";
    }

    // Call this and pass updated text to it to display
    public void UpdateText(string updatedText)
    {
        bodyTextContent = updatedText;
    }
    
    // Update is called once per frame
    void Update ()
    {
		
	}
}
