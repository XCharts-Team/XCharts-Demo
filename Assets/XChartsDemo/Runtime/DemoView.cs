
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using XCharts;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    internal class DemoView : MonoBehaviour
    {
        private void Awake()
        {
            UIUtil.SetText(gameObject, XChartsMgr.fullVersion, "panel_top/logo/version");
        }
    }
}