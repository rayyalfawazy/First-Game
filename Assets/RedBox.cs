using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RedBox : MonoBehaviour
{
    [SerializeField] UnityEvent OnGetRed;
    [SerializeField] UnityEvent OnExitRed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnGetRed.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        OnExitRed.Invoke();
    }
}
