using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class ChartButton : MonoBehaviour
    {

        private void Awake()
        {
        }

        public void AddBtnListener(UnityAction action)
        {
            var btn = gameObject.GetComponent<Button>();
            btn.onClick.AddListener(action);
        }
    }
}