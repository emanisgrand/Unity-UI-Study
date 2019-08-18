using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ToggleTest : MonoBehaviour
{
    ToggleGroup toggleGroupinstance;

    public Toggle currentSelection{
        get {return toggleGroupinstance.ActiveToggles().FirstOrDefault();}
    }
  
    void Start()
    {
        toggleGroupinstance = GetComponent<ToggleGroup>();    
        Debug.Log("Linq: First selected " + currentSelection.name);

        //activate the third item in the toggle group
        SelectToggle(0);
    }

    public void SelectToggle(int id){
        //a list of all the ids in the toggle group
        var toggles = toggleGroupinstance.GetComponentsInChildren<Toggle>();

        toggles[id].isOn = true;

    }
}
