using FIMSpace.FTail;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoringTrigger : MonoBehaviour
{
    [SerializeField] TailAnimator2 _tailAnimator;
    private void Start() => _tailAnimator = GameManager.Instance.References.TailAnimator;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _tailAnimator.UseIK = true;
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _tailAnimator.UseIK = false;
        }
            
    }
}
