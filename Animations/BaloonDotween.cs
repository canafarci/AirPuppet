using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BaloonDotween : MonoBehaviour, IDotween
{
    public void DOTweenAnimation()
    {
        transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 1f);
    }
}
