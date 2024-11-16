using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]Text textComponent; // serialize field is used for maintaining value reference; 
    // Start is called before the first frame update
    [SerializeField] State startingState; // this is a reference to the State scriptable object
    State State; // calling the State scriptable object

    void Start()
    {   
        State = startingState; // this is the starting state of the game
        textComponent.text = State.GetStateStory(); //this add a programmatically text to the text component

    }
    // Update is called once per frame
    void Update()   {  manageState();}
    private void manageState()
    {
        var nextStates = State.GetNextStates(); // this is the next state of the game
    for(int element = 0; element < nextStates.Length; element++){
        if(Input.GetKeyDown(KeyCode.Alpha1 + element))  {   State = nextStates[element];    }   }
        textComponent.text = State.GetStateStory(); //this add a programmatically text to the text component
    }
}
