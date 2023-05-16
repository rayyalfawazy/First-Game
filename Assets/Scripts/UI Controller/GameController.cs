using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public StoryScene currentScene;
    public DialogueBoxController dialogueBox;

    void Start()
    {
        dialogueBox.PlayScene(currentScene);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            if (dialogueBox.IsCompleted())
            {
                
                if (dialogueBox.IsLastSentence())
                {
                    currentScene = currentScene.nextScene;
                    dialogueBox.PlayScene(currentScene);
                }
                else
                {
                    dialogueBox.PlayNextSentence();
                }
            }
        }
    }
}
