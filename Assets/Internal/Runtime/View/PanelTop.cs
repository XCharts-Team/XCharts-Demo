using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class PanelTop : MonoBehaviour
    {
        [SerializeField] private Color m_ButtonNormalColor;
        [SerializeField] private Color m_ButtonSelectedColor;
        [SerializeField] private Color m_ButtonHighlightColor;
        [SerializeField] public int lastSelectedModuleIndex = -1;
        [SerializeField] private List<ChartModule> m_ChartModule = new List<ChartModule>();

        void Start()
        {

        }

        void Update()
        {

        }
    }
}
