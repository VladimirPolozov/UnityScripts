using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string myString = "none";
    public float myFloat;
    public int myInt = 2;
    public int[] myArray = new int[4];
    public bool myBooleanVariable = true;
    List<string> myStringList = new List<string>(); 
    Dictionary<int, string> myDictionary = new Dictionary<int, string>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < myInt; ++i) { 
            Debug.Log("Hello world!");
        }
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}