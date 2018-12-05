using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Vishal
{
    [CustomEditor(typeof(IP_BaseAirplane_Input))]
    public class IP_BaseAirplaneInput_Editor : Editor
    {

        #region variables
        private IP_BaseAirplane_Input targetInput;
        #endregion

        #region buildin methods
        private void OnEnable()
        {
            targetInput = (IP_BaseAirplane_Input)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            //Custom editor code
            GUILayout.Space(20);
            string debugInfo = "";
            debugInfo += "Pitch = " + targetInput.Pitch + "\n";
            debugInfo += "Roll = " + targetInput.Roll + "\n";
            debugInfo += "Yaw = " + targetInput.Yaw + "\n";
            debugInfo += "Throttle = " + targetInput.Throttle + "\n";
            debugInfo += "Brake = " + targetInput.Brake + "\n";
            debugInfo += "Flap = " + targetInput.Flaps + "\n";

            EditorGUILayout.TextArea(debugInfo, GUILayout.Height(100));
            GUILayout.Space(20);

            Repaint();
        }
        #endregion
    }
}

