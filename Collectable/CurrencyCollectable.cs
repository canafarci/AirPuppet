using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyCollectable : Collectable
{
    public static event Action<float> OnCurrencyPickup;
    [SerializeField] protected float _destroyDelay;

    public override void OnCollected()
    {
        base.OnCollected();

        if (_vfx != null)
        {
            GameObject effect = Instantiate(_vfx, (transform.position + _vfx.transform.position), _vfx.transform.rotation);
            Destroy(effect, _destroyDelay + 1f);
            Destroy(gameObject, _destroyDelay);
        }
        else
            Destroy(gameObject, 0.1f);

        OnCurrencyPickup?.Invoke(_changeAmount);
    }

}
