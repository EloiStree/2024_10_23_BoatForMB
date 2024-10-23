using UnityEditor;
using UnityEngine;

namespace Eloi
{
    [CustomEditor(typeof(BasicBoatMono))]
    public class BasicBoatEditorMono: Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            BasicBoatMono t = (BasicBoatMono)target;
            if (GUILayout.Button("Teleport Forward"))
            {
                t.TeleportForward();
            }
        }
    }
}
