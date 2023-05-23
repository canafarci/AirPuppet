using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    DynamicJoystick _joystick;
    private void Awake() => _joystick = FindObjectOfType<DynamicJoystick>();
    private void Update() => ReadInput();
    public float ReadInput() => _joystick.Horizontal;
}
