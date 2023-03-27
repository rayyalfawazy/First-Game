using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class AnimationController : MonoBehaviour
{
    public void AfterFade(string sceneName)
    {
        Debug.Log("Animation Completed");
        SceneManager.LoadScene(sceneName);
    }
}
