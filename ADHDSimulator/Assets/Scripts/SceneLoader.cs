using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || RollEvent.rollDone)
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        // switch between dice scene and game scene
        int nextScene = 0;
        if (SceneManager.GetActiveScene().buildIndex == 0 )
        {
            nextScene = 1;
        }
        StartCoroutine(LoadScene(nextScene));
    }

    IEnumerator LoadScene(int sceneIndex)
    {
        transition.SetTrigger("Start");

        // reset transition flag
        RollEvent.rollDone = false;

        // wait for fade animation before switching scenes
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sceneIndex);
    }
}
