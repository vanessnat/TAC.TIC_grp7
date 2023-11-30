using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct ComputerPage
{
    public string text;
    public Color color;

    public GameObject objectToActivate;
    public GameObject objectToDesactivate;
}

public class ComputerClue : MonoBehaviour
{
    public string correctCode = "1607"; // Code correct pour résoudre l'énigme.
    public InputField inputField;
    public Text inputFieldText; // Référence à l'InputField dans l'interface utilisateur.
    public Text feedbackText; // Référence au texte de feedback.

    public GameObject objectToActiveWhenCorrect = null;

    private void Start()
    {
        // Assurez-vous que le champ de texte est vide au départ.
        inputField.text = "";
    }

    private void Update()
    {
        // Vérifie si la touche "Enter" est pressée pour soumettre le code.
        if (Input.GetKeyDown(KeyCode.Return))
        {
           // CheckCode();
        }
    }

    // Fonction pour vérifier le code soumis.
    public void CheckCode()
    {
        // Obtient le texte entré par le joueur.
        string enteredCode = inputFieldText.text;

        Debug.Log(enteredCode);

        // Vérifie si le code est correct.
        if (enteredCode == correctCode)
        {
            // Affiche un feedback positif.
            feedbackText.text = "La porte est ouverte !";
            objectToActiveWhenCorrect.SetActive(true);
            objectToActiveWhenCorrect.GetComponent<ControllerDoor>().doorLock = false;
            
        }
        else
        {
            // Affiche un feedback négatif.
            feedbackText.text = "Code incorrect. Réessayez.";
        }

        // Réinitialise le champ de texte.
        inputField.text = "";
    }
}
