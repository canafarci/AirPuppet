using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsAudio : MonoBehaviour
{
    AudioSource _audioSource;
    private void Awake() => _audioSource = GetComponent<AudioSource>();
    private void OnEnable() => GameStart.OnGameStart += ToggleFootstepsAudio;
    private void OnDisable() => GameStart.OnGameStart -= ToggleFootstepsAudio;

    public void ToggleFootstepsAudio()
    {
        if (_audioSource.isPlaying)
            _audioSource.Stop();
        else
            _audioSource.Play();
    }
}
