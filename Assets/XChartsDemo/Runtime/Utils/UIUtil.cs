
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace XChartsDemo
{
    internal static class UIUtil
    {

        public static GameObject Instantiate(GameObject clone, Transform parent, string name)
        {
            var obj = GameObject.Instantiate(clone);
            obj.name = name;
            obj.layer = LayerMask.NameToLayer("UI");
            obj.transform.SetParent(parent, true);
            obj.transform.localScale = Vector3.one;
            obj.transform.localPosition = Vector3.zero;
            obj.SetActive(true);
            return obj;
        }

        public static T GetComponent<T>(GameObject parent, string subPath) where T : MonoBehaviour
        {
            var trans = GetTransform(parent, subPath);
            if (trans == null) return default(T);
            return trans.GetComponent<T>();
        }

        public static RectTransform GetRectTransform(Transform transform, string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                transform = transform.Find(path);
            }
            if (transform != null)
            {
                return transform.gameObject.GetComponent<RectTransform>();
            }
            return null;
        }

        public static Transform GetTransform(Transform transform, string path)
        {
            if (!string.IsNullOrEmpty(path))
                return transform.Find(path);
            else
                return transform;
        }

        public static Transform GetTransform(GameObject gameObject, string path)
        {
            return GetTransform(gameObject.transform, path);
        }
        public static void SetRectTransformWidth(Transform transform, float width, string path = null)
        {
            var rect = GetRectTransform(transform, path);
            if (rect != null)
            {
                rect.sizeDelta = new Vector2(width, rect.sizeDelta.y);
            }
        }
        public static void SetRectTransformHeight(Transform transform, float height, string path = null)
        {
            var rect = GetRectTransform(transform, path);
            if (rect != null)
            {
                rect.sizeDelta = new Vector2(rect.sizeDelta.x, height);
            }
        }
        public static void SetRectTransformLeft(Transform transform, float width, string path = null)
        {
            var rect = GetRectTransform(transform, path);
            if (rect != null)
            {
                rect.anchoredPosition = new Vector2(width, rect.anchoredPosition.y);
            }
        }
        public static void SetRectTransformLeftRight(Transform transform, float left, float right, string path = null)
        {
            var rect = GetRectTransform(transform, path);
            if (rect != null)
            {
                rect.anchoredPosition = new Vector2(left, right);
            }
        }

        public static void ResetRectTransform(Transform transform, string path = null)
        {
            var rect = GetRectTransform(transform, path);
            if (rect != null)
            {
                rect.anchoredPosition = Vector2.zero;
                rect.offsetMax = Vector2.zero;
                rect.offsetMin = Vector2.zero;
            }
        }

        public static void SetGridLayoutGroup(Transform transform, Vector2 cellSize, Vector2 spacing, string path = null)
        {
            if (!string.IsNullOrEmpty(path))
            {
                transform = transform.Find(path);
            }
            if (transform != null)
            {
                var com = transform.gameObject.GetComponent<GridLayoutGroup>();
                if (com != null)
                {
                    com.cellSize = cellSize;
                    com.spacing = spacing;
                }
                else
                {
                    Debug.LogError("SetGridLayoutGroupSize ERROR:can't find GridLayoutGroup: " + (transform.name + "/" + path));
                }
            }
        }

        public static void SetText(GameObject parent, string text, string subPath = null)
        {
            if (!string.IsNullOrEmpty(subPath))
            {
                parent.transform.Find(subPath).GetComponent<Text>().text = text;
            }
            else
            {
                parent.GetComponent<Text>().text = text;
            }
        }

        public static Button SetButton(GameObject parent, string subPath, UnityAction action)
        {
            var buttonTran = GetTransform(parent.transform, subPath);
            if (buttonTran == null)
                throw new System.Exception("can't find:" + subPath + " in " + parent.name);

            var button = buttonTran.GetComponent<Button>();
            button.onClick.AddListener(action);
            return button;
        }

        public static void SetButtonColor(Button button, Color normalColor, Color selectedColor, Color highlightedColor)
        {
            var block = button.colors;
            block.highlightedColor = highlightedColor;
#if UNITY_2019
            block.selectedColor = selectedColor;
#endif
            block.pressedColor = selectedColor;
            block.normalColor = normalColor;
            button.colors = block;
        }

        public static void SetActive(GameObject parent, bool flag, string subPath)
        {
            var trans = GetTransform(parent, subPath);
            if (trans != null)
            {
                trans.gameObject.SetActive(flag);
            }
        }

        public static void SetActiveAllChildren(GameObject parent, bool flag)
        {
            for (int i = 0; i < parent.transform.childCount; i++)
            {
                parent.transform.GetChild(i).gameObject.SetActive(flag);
            }
        }
    }
}