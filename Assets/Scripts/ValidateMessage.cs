using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidateMessage : MonoBehaviour
{
    [SerializeField] List<Text> messageElements = new List<Text>();
    [SerializeField] GameObject messagePrefab = null;
    [SerializeField] GameObject player = null;
    [SerializeField] GameObject worlds = null;

   public void Validate()
    {
        string message = "";
        for (int i = 0; i < messageElements.Count; i ++) 
        {
            message += messageElements[i].text + " ";
        }

        GameObject newMessage = Instantiate(messagePrefab);
        newMessage.transform.position = player.transform.position;

        newMessage.GetComponent<Dialog>().SetOneLineDialog(message);

        foreach (Transform currentChild in worlds.transform)
        {
            if (currentChild.gameObject.activeSelf)
            {
                newMessage.transform.parent = currentChild;
            }
        }
        
        //Debug.Log(message);
        //Debug.Log(whereText.text + " ; " + whatText.text + " ; " + howText.text);
    }
}
