using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelConfig", menuName = "Config/New Config", order = 0)]
public class LevelConfig : ScriptableObject
{
    public float AfterSplashDelay;
    public float PlayerSpeed;
    public float PlayerSwipeSpeed;
    public float FXDestroyDelay;
    public float CollectableOverTimeFrequency;
    public AudioConfig ObstacleHit, ScoreIncrease, ScoreDecrease, StartRunning, DemolitionAudio, PaintAudio;
}

[System.Serializable]
public class AudioConfig
{
    public AudioClip Audio;
    public float Volume;
}
