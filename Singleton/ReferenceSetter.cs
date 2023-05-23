using FIMSpace.FTail;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceSetter : MonoBehaviour
{
    private void Start() => GameManager.Instance.References.TailAnimator = GetComponent<TailAnimator2>();
}