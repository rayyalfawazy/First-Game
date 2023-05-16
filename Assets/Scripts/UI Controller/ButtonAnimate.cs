using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimate : MonoBehaviour
{
    private void Start()
    {
        Animate();
    }

    public void Animate()
    {
        transform.DOScale(new Vector2(1.2f, 1.2f), 2)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
