using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    private void OnEnable() => SpawnColorSphere.OnEndGameCollision += GameEnd;
    private void OnDisable() => SpawnColorSphere.OnEndGameCollision -= GameEnd;

    private void GameEnd()
    {
        // disable player prefab
        transform.GetChild(0).gameObject.SetActive(false);
        // activate last camera
        GameManager.Instance.CameraController.ActivateCamera(CameraStrings.EndGameDollyCam);
        // trigger end game canvas
        StartCoroutine(FindObjectOfType<CanvasController>().EndGameCanvasBehaviour());
    }
}
