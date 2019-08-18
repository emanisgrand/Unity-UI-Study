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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
