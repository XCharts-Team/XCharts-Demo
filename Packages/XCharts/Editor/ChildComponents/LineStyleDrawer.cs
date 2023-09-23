using UnityEditor;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Editor
{
    [CustomPropertyDrawer(typeof(LineStyle), true)]
    public class LineStyleDrawer : BasePropertyDrawer
    {
        public override string ClassName { get { return "LineStyle"; } }
        public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent label)
        {
            base.OnGUI(pos, prop, label);
            if (MakeComponentFoldout(prop, "m_Show", true))
            {
                ++EditorGUI.indentLevel;
                PropertyField(prop, "m_Type");
                PropertyField(prop, "m_Color");
                PropertyField(prop, "m_ToColor");
                PropertyField(prop, "m_ToColor2");
                PropertyField(prop, "m_Width");
                PropertyField(prop, "m_Length");
                PropertyField(prop, "m_Opacity");
                PropertyField(prop, "m_DashLength");
                PropertyField(prop, "m_DotLength");
                PropertyField(prop, "m_GapLength");
                --EditorGUI.indentLevel;
            }
        }
    }
}