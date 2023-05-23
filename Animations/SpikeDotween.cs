using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDotween : MonoBehaviour, IDotween
{
    //public

    //private

    //monobehaviour methods

    //public methods
    public void DOTweenAnimation()
    {
        transform.DOPunchScale(new Vector3(0.2f, 0.2f, 0.2f), 10, 10);
    }

    //private methods

}
