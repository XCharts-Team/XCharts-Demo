using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XCharts;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class ChartThumb : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        Transform chartParent;
        private float m_Scale = 0.23f;
        private float m_ScaleSpeed = 1f;
        private float m_TargetScale = 0.23f;

        public bool isBind = false;
        public GameObject bindPrefab;

        private void Awake()
        {
            chartParent = transform.Find("mark/chart");
        }

        private void OnEnable()
        {
            if (!isBind)
            {
                BindPrefab(bindPrefab);
            }
        }

        private void Update()
        {
            if (m_Scale != m_TargetScale)
            {
                m_Scale += Time.deltaTime * m_ScaleSpeed;
                if (m_ScaleSpeed > 0 && m_Scale > m_TargetScale)
                    m_Scale = m_TargetScale;
                if (m_ScaleSpeed < 0 && m_Scale < m_TargetScale)
                    m_Scale = m_TargetScale;
                chartParent.localScale = new Vector3(m_Scale, m_Scale, m_Scale);
            }
        }

        public void BindPrefab(GameObject prefab)
        {
            if (prefab == null) return;
            bindPrefab = prefab;
            if (chartParent == null) return;
            ChartHelper.DestroyAllChildren(chartParent);
            var names = prefab.name.Split('_');
            var chart = UIUtil.Instantiate(prefab, chartParent, prefab.name);
            if (names.Length == 3)
            {
                UIUtil.SetText(gameObject, names[1], "desc/Text");
                UIUtil.SetText(gameObject, names[2], "desc/Text2");
            }
            isBind = true;
        }

        public void AddBtnListener(UnityAction action)
        {
            var btn = transform.Find("btn").GetComponent<Button>();
            btn.onClick.AddListener(action);
            OnPointerExit(null);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            m_TargetScale = 0.35f;
            m_ScaleSpeed = 0.4f;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            m_TargetScale = 0.25f;
            m_ScaleSpeed = -0.4f;
        }
    }
}