using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EditorStopPlayer))]
public class EditorStopPlayerGUI : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EditorStopPlayer myScript = (EditorStopPlayer)target;
        if (GUILayout.Button("Start/Stop"))
        {
            myScript.SwitchTimeScale();
        }
    }

}
