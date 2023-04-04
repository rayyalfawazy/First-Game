using System.Collections.Generic;
using UnityEngine;

// Membuat data untuk Story Scene
[CreateAssetMenu(fileName = "NewStoryScene", menuName = "Data/NewStoryScene")]

[System.Serializable] //Agar bisa dimanipulasi di Unity
public class StoryScene : ScriptableObject
{
    public List<Sentence> sentences;
    public Sprite backgroud;
    public StoryScene nextScene;

    [System.Serializable]
    public struct Sentence
    {
        [TextArea]public string text;
        public Speaker speaker; 
    }
}
