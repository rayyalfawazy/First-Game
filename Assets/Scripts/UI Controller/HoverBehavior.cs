using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HoverBehavior : MonoBehaviour
{
    TMP_Text text;
    private void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    public void StartHover()
    {
        text.fontStyle = FontStyles.Underline;
    }
    public void EndHover()
    {
        text.fontStyle = FontStyles.Normal;
    }
}
