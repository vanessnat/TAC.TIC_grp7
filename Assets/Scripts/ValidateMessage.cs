using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidateMessage : MonoBehaviour
{
    [SerializeField] Text whereText;
    [SerializeField] Text whatText;
    [SerializeField] Text howText;

   public void Validate()
    {
        Debug.Log(whereText.text + " ; " + whatText.text + " ; " + howText.text);
    }
}
