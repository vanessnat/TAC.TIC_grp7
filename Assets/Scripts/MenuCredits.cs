
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuCredits : MonoBehaviour
{
    public void LoadScene(string Credits){
        SceneManager.LoadScene(Credits);
    }
}
