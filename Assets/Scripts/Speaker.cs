using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Membuat data untuk Speaker (Pembicara)
[CreateAssetMenu(fileName ="NewSpeaker", menuName ="Data/NewSpeaker")]

[System.Serializable] //Agar bisa dimanipulasi di Unity
public class Speaker : ScriptableObject
{
    public string speakerName;
    public Color textColor;
}
