using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    [SerializeField] protected GameObject _vfx;
    [SerializeField] protected float _changeAmount;

    protected Collider _collider;

    virtual protected void Awake() => _collider = GetComponent<Collider>();

    public virtual void OnCollected()
    {
        _collider.enabled = false;

        IDotween dotween = GetComponent<IDotween>();
        if (dotween != null)
            dotween.DOTweenAnimation();
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            OnCollected();
    }
}