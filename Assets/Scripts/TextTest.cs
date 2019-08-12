using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTest : MonoBehaviour
{
    public string message;
    private Text textInstace;
    

    // Start is called before the first frame update
    void Start() {
        //? get the component of the text field on the game object this script is attached to
        //* set the value of the textInstance to equal the GetComponent method call and I pass in the text as a type for it to search for.
        textInstace = GetComponent<Text>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        textInstace.text = message;
    }
}
