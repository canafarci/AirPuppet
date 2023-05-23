using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyText : MonoBehaviour
{
    TextMeshProUGUI _text;
    float _currentCurrency;

    private void OnEnable() => CurrencyCollectable.OnCurrencyPickup += OnCurrencyCollected;
    private void OnDisable() => CurrencyCollectable.OnCurrencyPickup -= OnCurrencyCollected;


    private void Awake() => _text = GetComponent<TextMeshProUGUI>();

    private void OnCurrencyCollected(float change)
    {
        _currentCurrency += change;
        GameManager.Instance.Saver.SaveFloat(PrefKeys.Currency, _currentCurrency);
        _text.text = _currentCurrency.ToString();
    }

    
}
