
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using XCharts.Runtime;
using System.Text;
using System.Collections.Generic;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Image))]
    public class FPS : MonoBehaviour
    {
        private static StringBuilder s_Sb = new StringBuilder();

        private static readonly float INTERVAL = 0.2f;
        private static readonly float MAXCACHE = 20;
        private int m_FrameCount = 0;
        private float m_LastTime = 0f;
        private Text m_Text;
        private RectTransform m_ImageRect;
        private List<float> m_FpsList = new List<float>();
        private BaseChart m_Chart;
        private RectTransform m_ChartRect;

        public float fps { get; private set; }
        public float avgFps { get; private set; }

        private void Awake()
        {
            m_Text = gameObject.GetComponentInChildren<Text>();
            m_ImageRect = gameObject.GetComponent<Image>().GetComponent<RectTransform>();
            m_Chart = gameObject.GetComponentInChildren<BaseChart>();
            m_Chart.SetMaxCache(200);
            m_ChartRect = m_Chart.GetComponent<RectTransform>();
        }

        private void Update()
        {
            m_FrameCount++;
            if (Time.realtimeSinceStartup - m_LastTime >= INTERVAL)
            {
                fps = m_FrameCount / (Time.realtimeSinceStartup - m_LastTime);
                m_FrameCount = 0;
                m_LastTime = Time.realtimeSinceStartup;
                if (m_FpsList.Count > MAXCACHE)
                {
                    m_FpsList.RemoveAt(0);
                }
                m_FpsList.Add(fps);
                avgFps = GetAvg(m_FpsList);
                if (m_Text != null)
                {
                    s_Sb.Length = 0;
                    s_Sb.AppendFormat("CUR FPS: {0:f0}\n", fps);
                    s_Sb.AppendFormat("AVG FPS: {0:f0}", avgFps);
                    m_Text.text = s_Sb.ToString();
                    var width = m_Text.preferredWidth;
                    width  = (int)width - (int)width % 50 + 50;
                    m_ImageRect.sizeDelta = new Vector2(width + 8, m_Text.preferredHeight + 8);
                    m_Chart.AddData(0, fps);
                    m_Chart.AddXAxisData(string.Empty);
                    //m_ChartRect.anchoredPosition = new Vector2(width + 8, 0);
                }
            }
        }

        private static float GetAvg(List<float> list)
        {
            var total = 0f;
            foreach (var v in list) total += v;
            return total / list.Count;
        }
    }
}