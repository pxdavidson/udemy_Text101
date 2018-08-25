using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
  
    // Return text
    public string GetStoryText()
    {
        return storyText;
    }

    // Return states
    public State[] GetNextStates()
    {
        return nextStates;
    }
}
