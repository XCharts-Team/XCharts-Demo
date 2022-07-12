using System.IO;
using UnityEditor;
using UnityEngine;
using XCharts.Runtime;

public static class ChartUpdate
{

    [MenuItem("Tools/UpdateTooltip")]
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
            var chart = prefab.GetComponent<BaseChart>();
            if (chart != null)
            {
                Debug.LogError("file:" + assetPath + "," + chart);
                chart.RebuildChartObject();
                EditorUtility.SetDirty(prefab);
            }
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}