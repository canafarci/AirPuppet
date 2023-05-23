using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainterAudio : MonoBehaviour
{
    AudioSource _audioSource;
    bool _isPlaying;
    [SerializeField] float _duration;

    private void Awake() => _audioSource = GetComponent<AudioSource>();
    private void OnTriggerEnter(Collider other)
    {
        if (!_isPlaying && other.CompareTag("Player"))
        {
            StartCoroutine(Paint());
            _isPlaying = true;
        }
    }

    IEnumerator Paint()
    {
        _audioSource.Play();
        yield return new WaitForSeconds(_duration);
        _audioSource.Stop();
        this.enabled = false;
    }

}
