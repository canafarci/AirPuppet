using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticHitTrigger : Collectable
{
    public static event Action<float> OnStaticStackTriggerHit;
    //public

    //private
    [SerializeField] float hitBendTime = 0.3f;
    //monobehaviour methods

    //public methods
    public override void OnCollected()
    {
        base.OnCollected();
        if (_vfx != null)
        {
            GameObject effect = Instantiate(_vfx, (transform.position + _vfx.transform.position), _vfx.transform.rotation);
            Destroy(effect,  1f);
        }
            OnStaticStackTriggerHit?.Invoke(_changeAmount);
        StartCoroutine(OnHitDisable());
        StartCoroutine(HitFX());
    }

    //private methods
    IEnumerator OnHitDisable()
    {
        _collider.enabled = false;
        yield return new WaitForSeconds(1f);
        _collider.enabled = true;
    }

    IEnumerator HitFX()
    {
        AudioConfig config = GameManager.Instance.References.LevelConfig.ObstacleHit;
        GameManager.Instance.AudioManager.PlaySFX(config.Audio, config.Volume);
        GameManager.Instance.References.TailAnimator.UseIK = true;
        yield return new WaitForSeconds(hitBendTime);
        GameManager.Instance.References.TailAnimator.UseIK = false;
    }

}
