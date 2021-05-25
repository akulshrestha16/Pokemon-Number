using System.Collections; 
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    //public Text progreeText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadAsynchronously(1));
    }

    IEnumerator loadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        //loadingScreen.SetActive(true);
        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / -9f);
            slider.value = progress;
            //progreeText.text = progress * 100f + "%";

            yield return null;
        }
    }
}
 