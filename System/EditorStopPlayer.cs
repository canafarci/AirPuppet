using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorStopPlayer : MonoBehaviour
{
    static bool _playerStopped = false;

    public void SwitchTimeScale()
    {
        if (_playerStopped)
        {
            SetFollowerSpeed(GameManager.Instance.References.LevelConfig.PlayerSpeed);
            _playerStopped = false;
        }
            
        else
        {
            SetFollowerSpeed(0);
            _playerStopped = true;
        }
    }

    public void SetFollowerSpeed(float speed)
    {
        foreach (SplineFollower _sf in FindObjectsOfType<SplineFollower>())
        {
            _sf.followSpeed = speed;
        }
    }

}
