using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class CloneTerrain : EditorWindow
{
    GameObject copy;

    [MenuItem("Custom/CloneTerrain")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CloneTerrain));
    }

    void OnGUI()
    {
        copy = EditorGUILayout.ObjectField("Terrain to Copy:", copy, typeof(GameObject), true) as GameObject;
        if (GUILayout.Button("Go"))
        {
            Terrain ter = copy.GetComponent<Terrain>();
            ter.terrainData = (TerrainData)Object.Instantiate(ter.terrainData);
            TerrainCollider tc = copy.GetComponent<TerrainCollider>();
            tc.terrainData = ter.terrainData;
            AssetDatabase.CreateAsset(ter.terrainData, "Assets/" + ter.terrainData.name + ".asset");
        }
    }
}
