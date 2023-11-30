/* Author : Raphaël Marczak - 2018/2020, for MIAMI Teaching (IUT Tarbes) and MMI Teaching (IUT Bordeaux Montaigne)
 * 
 * This work is licensed under the CC0 License. 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This struct represents one dialog page
// (text on the current page, and its color)
[System.Serializable]
public struct DialogPage
{
    public string text;
    public Color color;

    public GameObject objectToActivate;
    public GameObject objectToDesactivate;
}

// This class is used to correctly display a full dialog
public class DialogManager : MonoBehaviour {

    public Text m_renderText;
    private List<DialogPage> m_dialogToDisplay;

  //  bool needToUpdatePage = true;

    void Awake () {

    }

    // Sets the dialog to be displayed
    public void SetDialog(List<DialogPage> dialogToAdd)
    {
        m_dialogToDisplay = new List<DialogPage>(dialogToAdd);

        if (m_dialogToDisplay.Count > 0)
        {
            if (m_renderText != null)
            {
               m_renderText.text = "";
            }

            this.gameObject.SetActive(true);
        }
    }

    public void ClearDialog() {
        m_dialogToDisplay.Clear();
    }
	
	// Update is called once per frame
	void Update () {
        if (m_renderText == null)
        {
            this.gameObject.SetActive(false);
        }

        // Displays the current page
		if (m_dialogToDisplay.Count > 0)
        {
            //needToUpdatePage = false;
            m_renderText.text = m_dialogToDisplay[0].text;

            if (m_dialogToDisplay[0].objectToActivate != null) {
                m_dialogToDisplay[0].objectToActivate.SetActive(true);
            }

            if (m_dialogToDisplay[0].objectToDesactivate != null) {
                m_dialogToDisplay[0].objectToDesactivate.SetActive(false);
            }

        } else
        {
            this.gameObject.SetActive(false);
        }

        // Removes the page when the player presses "space"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            m_dialogToDisplay.RemoveAt(0);
        }
	}

    public bool IsOnScreen()
    {
        return this.gameObject.activeSelf;
    }
}
