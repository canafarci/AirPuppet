using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DemolitionAudio : MonoBehaviour
{
    bool _playedAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!_playedAudio)
            {
                _playedAudio = true;
                AudioConfig config = GameManager.Instance.References.LevelConfig.DemolitionAudio;
                GameManager.Instance.AudioManager.PlaySFX(config.Audio, config.Volume);
            }
            
            this.enabled = false;
        }
            
    }

}
