using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application Quits");
    }
    public void ShowWorldSelection(){
        SceneManager.LoadScene("World Selection");

    }
    public void ShowEuropeanLevelSelection(){
        SceneManager.LoadScene("European Levels");
    }

}
