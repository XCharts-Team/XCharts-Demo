
using UnityEngine;
using UnityEditor;
using System.IO;
using XCharts.Runtime;

public static class ChartUpdate
{

    //[MenuItem("Tools/UpdateTooltip")]
    public static void UpdateTooltip()
    {
        var files = new DirectoryInfo(Application.dataPath).GetFiles("*.prefab", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var index = file.FullName.IndexOf("Assets/");
            var assetPath = file.FullName.Substring(index);
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
            var chart = prefab.GetComponent<BaseChart>();
            if (chart != null)
            {
                Debug.LogError("file:" + assetPath + "," + chart);
                var tooltip = chart.GetChartComponent<Tooltip>();
                if (tooltip != null)
                {
                    tooltip.contentLabelStyles[0].textPadding.SetPadding(0, 5, 0, 0);
                    tooltip.contentLabelStyles[1].textPadding.SetPadding(0, 25, 0, 0);
                    tooltip.contentLabelStyles[2].textPadding.SetPadding(0, 0, 0, 0);
                    EditorUtility.SetDirty(prefab);
                }
            }
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    [MenuItem("Tools/RebuildAllChart")]
    public static void RebuildAllChart()
    {
        var files = new DirectoryInfo(Application.dataPath).GetFiles("*.prefab", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var index = file.FullName.IndexOf("Assets/");
            var assetPath = file.FullName.Substring(index);
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
            RebuildChartPrefab(prefab);
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    [MenuItem("Assets/XCharts/RebuildChart")]
    public static void RebuildSelectedChart()
    {
        foreach (var obj in Selection.objects)
        {
            RebuildChartPrefab(obj);
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    [MenuItem("Assets/XCharts/CopyChart")]
    public static void CopySelectedChart()
    {
        foreach (var obj in Selection.objects)
        {
            var assetPath = AssetDatabase.GetAssetPath(obj);
            var newPath = assetPath.Replace(".prefab", "_copy.prefab");
            AssetDatabase.CopyAsset(assetPath, newPath);
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    private static void RebuildChartPrefab(Object obj)
    {
        var prefab = PrefabUtility.InstantiatePrefab(obj) as GameObject;
        if (prefab != null)
        {
            var chart = prefab.GetComponent<BaseChart>();
            if (chart != null)
            {
                Debug.LogError("RebuildChartPrefab:" + AssetDatabase.GetAssetPath(prefab) + "," + chart);
                chart.RebuildChartObject();
#if UNITY_2018_3_OR_NEWER
                PrefabUtility.SaveAsPrefabAsset(prefab, AssetDatabase.GetAssetPath(obj));
#else
                PrefabUtility.ReplacePrefab(prefab, obj, ReplacePrefabOptions.ConnectToPrefab);
#endif
                GameObject.DestroyImmediate(prefab);
            }
        }
    }
}