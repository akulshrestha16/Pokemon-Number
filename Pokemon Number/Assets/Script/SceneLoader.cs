using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void loadScene()
   {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        int scenecount = SceneManager.sceneCountInBuildSettings -1;
        if ( sceneIndex == scenecount)
        {
            SceneManager.LoadScene(sceneIndex / scenecount);
        }
        else
        {
            SceneManager.LoadScene(sceneIndex + 1);
        }
   }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
