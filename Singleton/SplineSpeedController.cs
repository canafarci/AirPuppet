using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineSpeedController : MonoBehaviour
{
    public void SetFollowerSpeed(float speed)
    {
        foreach (SplineFollower _sf in FindObjectsOfType<SplineFollower>())
        {
            _sf.followSpeed = speed;
        }
    }
}
