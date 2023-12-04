using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadScene(string SceneRDC){
        SceneManager.LoadScene(SceneRDC);
    }

    public void doExitGame() {
    Application.Quit();
    }
}
