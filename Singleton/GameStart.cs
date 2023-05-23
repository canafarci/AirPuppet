using System;
using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameStart : MonoBehaviour
{
    SplineFollower[] splineFollowers;

    public static event Action OnGameStart;


    private void Update()
    {
        if (Input.anyKeyDown)
            FirstReadInput();
    }

    private void FirstReadInput()
    {
        GameManager.Instance.SplineSpeedController.SetFollowerSpeed(GameManager.Instance.References.LevelConfig.PlayerSpeed);

        OnGameStart?.Invoke();

        this.enabled = false;
    }
}
