using FIMSpace.FTail;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stacker : MonoBehaviour
{
   [SerializeField] TailAnimator2 _tailAnimator;
    float _length = 2f;

    Coroutine _soundSFXRoutine = null;
    private void OnEnable()
    {
        StackCollectable.OnStackCollectablePickup += OnStackPickup;
        StackCollectableOverTime.OnStackCollectableOverTime += OnOverTimePickup;
        StaticHitTrigger.OnStaticStackTriggerHit += OnStackPickup;
    }
    private void OnDisable()
    {
        StackCollectable.OnStackCollectablePickup -= OnStackPickup;
        StackCollectableOverTime.OnStackCollectableOverTime -= OnOverTimePickup;
        StaticHitTrigger.OnStaticStackTriggerHit -= OnStackPickup;
    }
        

    private void OnStackPickup(float increaseAmount)
    {
        _length += increaseAmount;
        _tailAnimator.LengthMultiplier = _length;

        if (increaseAmount > 0)
        {
            AudioConfig config = GameManager.Instance.References.LevelConfig.ScoreIncrease;
            GameManager.Instance.AudioManager.PlaySFX(config.Audio, config.Volume);
        }
            
        else
        {
            AudioConfig config = GameManager.Instance.References.LevelConfig.ScoreDecrease;
            GameManager.Instance.AudioManager.PlaySFX(config.Audio, config.Volume);
        }
    }

    private void OnOverTimePickup(float increaseAmount)
    {
        _length += increaseAmount;
        _tailAnimator.LengthMultiplier = _length;

        if (_soundSFXRoutine == null)
            _soundSFXRoutine = StartCoroutine(OverTimeSFX(increaseAmount));
    }

    IEnumerator OverTimeSFX(float increaseAmount)
    {
        if (increaseAmount > 0)
        {
            AudioConfig config = GameManager.Instance.References.LevelConfig.ScoreIncrease;
            GameManager.Instance.AudioManager.PlaySFX(config.Audio, config.Volume);
        }

        else
        {
            AudioConfig config = GameManager.Instance.References.LevelConfig.ScoreDecrease;
            GameManager.Instance.AudioManager.PlaySFX(config.Audio, config.Volume);
        }
        yield return new WaitForSeconds(0.5f);
        _soundSFXRoutine = null;
    }
}
