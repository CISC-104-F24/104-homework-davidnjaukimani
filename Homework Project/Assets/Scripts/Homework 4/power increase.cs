using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // <-- Add this line to use TextMeshPro

public class Increasepower : MonoBehaviour
{
    TMP_Text textField;  // Reference to the TextMeshPro component
    int number = 0;  // Initialize the number

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject by name and get the TextMeshPro component
        textField = GameObject.Find("powerCounter").GetComponent<TMP_Text>();

        // Check if the textField was successfully found
        if (textField == null)
        {
            Debug.LogError("TextMeshPro component not found on 'hpCounter' GameObject!");
        }
    }

    public void ChangeText()
    {
        number += 10;
        textField.text = number.ToString();
    }
}
