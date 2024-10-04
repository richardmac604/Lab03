using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateButtons : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform content;
    public int numButtons = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numButtons; i++)
        {
            MyButton b = Instantiate(buttonPrefab, content).GetComponent<MyButton>();
            b.SetText("Button " + i);
            b.callback = ButtonClicked;
        }
    }

    public void ButtonClicked(string buttonText)
    {
        Debug.Log("Clicked " + buttonText);
    }
}
