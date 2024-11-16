using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "State")]
public class State : ScriptableObject
{
public int count = 0, state = 0;
    // Start is called before the first frame update
    [TextArea(14,10)][SerializeField] String StoryText;
    [SerializeField] State[] nextStates;
    public string GetStateStory()
    {
        Debug.Log("New StoryLine got" + ++count);
        return StoryText;
    }
    public State[] GetNextStates()
    {
        Debug.Log("New State got" + ++state);
        return nextStates;
    }
}
