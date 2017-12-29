using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = target as MapGenerator;

        // DrawDefaultInspector return true if something changed
        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
                mapGen.DrawMapInEditor();
        }

        if (GUILayout.Button("Generate"))
        {
            mapGen.DrawMapInEditor();
        }
    }
}
