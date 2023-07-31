using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEditorInternal;
using System;

namespace WebGame.Tools.Edits
{
    using System.IO;
    using WebGame.Game.Mechanical;

    [CustomEditor(typeof(URLEvent) , true)]
    [CanEditMultipleObjects]
    public class EditorURL : Editor
    {
        #region Attributes
        bool _doOnce;
        bool _isAnimationCorrutine;
        bool _isFlipFlop;
        Texture2D _image;
        #endregion

        #region Editor Calls
        public override void OnInspectorGUI()
        {

            URLEvent script = target as URLEvent;

            if ( !_doOnce )
            {
                string folderPath = "Assets/Images/Img_WebGame/Pergaminao_01.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                _doOnce = true;
            }

            EditorGUILayout.BeginHorizontal();
            GUIStyle helpBoxStyle = new GUIStyle(EditorStyles.helpBox);
            helpBoxStyle.fontSize = 16; // Tamaño de fuente personalizado
            Rect helpBoxRect = GUILayoutUtility.GetRect(GUIContent.none, helpBoxStyle, GUILayout.Height(50));
            GUI.Box(helpBoxRect , "Bienvenido a mi edicion profesional" , helpBoxStyle);
            SerializedProperty _stringLink = serializedObject.FindProperty("_urlText");
            if ( GUILayout.Button(new GUIContent("Explication" , _image) , GUILayout.Height(50) , GUILayout.Width(100)) )
            {
                _isFlipFlop = !_isFlipFlop;
            }

            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginVertical();
            if ( GUILayout.Button("Opten Scritp: URL Event ") )
            {
                MonoScript script1 = MonoScript.FromMonoBehaviour(target as MonoBehaviour);
                AssetDatabase.OpenAsset(script1);

            }
            if ( GUILayout.Button("Opten Scritp: EditorURL ") )
            {

                string editorScriptPath = AssetDatabase.GetAssetPath(MonoScript.FromScriptableObject(this));
                string fullPath = Path.GetFullPath(editorScriptPath);
                EditorUtility.OpenWithDefaultApp(fullPath);
            }
            EditorGUILayout.EndVertical();
            if ( _isFlipFlop )
            {
                EditorGUILayout.HelpBox("Pasa cual sera el animator y despues la duracion de la animacion para que pueda cargar el nivel" , MessageType.Info);
                if ( !_isAnimationCorrutine )
                {
                    EditorApplication.update += ProcessDownload;
                    currentDownload = IEAnimationScroll();
                    _isAnimationCorrutine = true;
                }
            }
            else
            {
                if ( _isAnimationCorrutine )
                {

                    EditorApplication.update += ProcessDownload;
                    currentDownload = IEAnimationScroll();
                    _isAnimationCorrutine = false;
                }

            }
            EditorGUILayout.PropertyField(_stringLink , true);
            serializedObject.Update();
           
        }
        #endregion

        #region custom privat method
        private IEnumerator currentDownload;
        private void ProcessDownload()
        {
            currentDownload?.MoveNext();
        }
        public IEnumerator IEAnimationScroll()
        {
            string folderPath;
            if ( _isFlipFlop )
            {

                folderPath = "Assets/Images/Img_WebGame/Pergaminao_01.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                yield return new WaitForSeconds(0.0001f);
                folderPath = "Assets/Images/Img_WebGame/Pergaminao_02.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                yield return new WaitForSeconds(0.0001f);
                folderPath = "Assets/Images/Img_WebGame/Pergaminao_03.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                EditorApplication.update -= ProcessDownload;
            }
            else
            {
                folderPath = "Assets/Images/Img_WebGame/Pergaminao_03.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                yield return new WaitForSeconds(0.0001f);
                folderPath = "Assets/Images/Img_WebGame/Pergaminao_02.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                yield return new WaitForSeconds(0.0001f);
                folderPath = "Assets/Images/Img_WebGame/Pergaminao_01.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                EditorApplication.update -= ProcessDownload;
            }
        }
        #endregion
    }
}
