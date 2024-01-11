using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string menuScenename = "MainMenu";
    
    // Start is called before the first frame update
    public void Menu()
    {
        SceneManager.LoadScene(menuScenename);
        
    }

    
}
