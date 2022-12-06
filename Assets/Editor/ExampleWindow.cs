using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{
    Color color;

    [MenuItem("Window/Colorizer")]
    public static void ShowWindow ()
    {
        GetWindow<ExampleWindow>("Colorizer");
    }
    void OnGUI ()
    {
        GUILayout.Label("Color the selected object!", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("COLORIZE!"))
        {
            Colorize();
        }
    }

    void Colorize ()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();
            if (renderer != null)
            {
                renderer.color = color;
            }
        }
    }
}
