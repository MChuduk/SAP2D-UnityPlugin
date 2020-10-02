using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace SAP2D.Editors 
{
    public class GridsDispatcherWindow : EditorWindow
    {

        private string visualTreePath = "Assets/SAP2D/Core/Code/Editor/GridsDispatcherVTree.uxml";

        [MenuItem("Tools/SAP2D/Grids Dispatcher")]
        public static void ShowWindow()
        {
            EditorWindow window = GetWindow<GridsDispatcherWindow>();

            window.titleContent = new GUIContent("Grids Dispatcher");
            window.Show();
        }

        private void OnEnable()
        {
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(visualTreePath);

            visualTree.CloneTree(rootVisualElement);
        }
    }
}