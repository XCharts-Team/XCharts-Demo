using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class ChartThumb : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler//, IPointerClickHandler, IPointerDownHandler,IPointerUpHandler
    {
        Transform chartParent;
        private float m_Scale = 0.23f;
        private float m_ScaleSpeed = 1f;
        private float m_TargetScale = 0.23f;
        private Button m_Button;

        public int index;
        public bool isBindPrefab = false;
        public bool isBindAction = false;
        public GameObject bindPrefab;
        public UnityAction bindAction;

        private void Awake()
        {
            chartParent = transform.Find("mark/chart");
            m_Button = transform.Find("btn").GetComponent<Button>();
        }

        private void OnEnable()
        {
            if (!isBindPrefab)
            {
                BindPrefab(bindPrefab);
            }
            if (!isBindAction)
            {
                AddBtnListener(bindAction);
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
            isBindPrefab = true;
        }

        public void Click(){
            bindAction();
        }

        public void AddBtnListener(UnityAction action)
        {
            if (action == null) return;
            bindAction = action;
            if (m_Button == null) return;
            m_Button.onClick.RemoveAllListeners();
            m_Button.onClick.AddListener(action);
            OnPointerExit(null);
            isBindAction = true;
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