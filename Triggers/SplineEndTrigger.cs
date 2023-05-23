using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineEndTrigger : MonoBehaviour
{
    [SerializeField] float _endSpeed;

    public void OnEndTrigger()
    {
        AudioConfig config = GameManager.Instance.References.LevelConfig.StartRunning;
        GameManager.Instance.AudioManager.PlaySFX(config.Audio, config.Volume);
        GameManager.Instance.SplineSpeedController.SetFollowerSpeed(_endSpeed);
        GameManager.Instance.CameraController.ActivateCamera(CameraStrings.EndGameFollowCam);
    }
}
