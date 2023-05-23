using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCollectableOverTime : MonoBehaviour
{
    //public
    public static event Action<float> OnStackCollectableOverTime;
    //private
    [SerializeField] protected float _increaseAmount;
    static Coroutine _overTimecoroutine, _checkPlayerRoutine;
    static bool _playerInsideTrigger;
    bool _playerIsInside;

    private void Start()
    {
        if (_checkPlayerRoutine == null)
            _checkPlayerRoutine = StartCoroutine(CheckPlayerIsInside());
    }

    //monobehaviour methods
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (_overTimecoroutine != null)
                StopCoroutine(_overTimecoroutine);

            _overTimecoroutine = StartCoroutine(StackOverTimeRoutine());
            _playerIsInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            _playerIsInside = false;
    }

    //public methods

    //private methods
    IEnumerator StackOverTimeRoutine()
    {
        OnStackCollectableOverTime?.Invoke(_increaseAmount);
        while(_playerInsideTrigger)
        {
            yield return new WaitForSeconds(GameManager.Instance.References.LevelConfig.CollectableOverTimeFrequency);
            OnStackCollectableOverTime?.Invoke(_increaseAmount);
        }
    }

    IEnumerator CheckPlayerIsInside()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.25f);
            _playerInsideTrigger = _playerIsInside;
        }
    }
}
