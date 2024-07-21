
using UnityEngine;
using UnityEditor;
using System.IO;
using XCharts.Runtime;
using XChartsDemo;

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
            var path = file.FullName.Replace("\\", "/");
            var index = path.IndexOf("Assets/");
            var assetPath = path.Substring(index);
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
            RebuildChartPrefab(prefab);
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    
    [MenuItem("Tools/ResetAllChartConfigurations")]
    public static void ResetChartConfigurations()
    {
        var files = new DirectoryInfo(Application.dataPath).GetFiles("*.prefab", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var path = file.FullName.Replace("\\", "/");
            var index = path.IndexOf("Assets/");
            var assetPath = path.Substring(index);
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
            ResetChartConfigurations(prefab);
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
    
    [MenuItem("Tools/SetAllBackgroundComponent")]
    public static void SetAllBackgroundComponent()
    {
        var files = new DirectoryInfo(Application.dataPath).GetFiles("*.prefab", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var path = file.FullName.Replace("\\", "/");
            var index = path.IndexOf("Assets/");
            var assetPath = path.Substring(index);
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
            SetBackgroundComponent(prefab);
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

    [MenuItem("Assets/XCharts/SetBackgroundComponent")]
    public static void SetBackgroundComponent()
    {
        foreach (var obj in Selection.objects)
        {
            SetBackgroundComponent(obj);
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

    [MenuItem("Assets/XCharts/SyncDemoConfigPrefabNames")]
    public static void SyncDemoConfigPrefabNames()
    {
        foreach (var obj in Selection.objects)
        {
            if (obj.name == "DemoConfig")
            {
                var assetPath = AssetDatabase.GetAssetPath(obj);
                var config = AssetDatabase.LoadAssetAtPath<DemoConfig>(assetPath);
                config.Init();
                EditorUtility.SetDirty(config);
            }
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    [MenuItem("Assets/XCharts/RemoveDemoConfigMissingPrefab")]
    public static void RemoveDemoConfigMissingPrefab()
    {
        foreach (var obj in Selection.objects)
        {
            if (obj.name == "DemoConfig")
            {
                var assetPath = AssetDatabase.GetAssetPath(obj);
                var config = AssetDatabase.LoadAssetAtPath<DemoConfig>(assetPath);
                config.RemoveMissingPrefab();
                EditorUtility.SetDirty(config);
            }
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
                Debug.Log("RebuildChartPrefab:" + AssetDatabase.GetAssetPath(prefab) + "," + chart);
                chart.RebuildChartObject();
#if UNITY_2018_3_OR_NEWER
                PrefabUtility.SaveAsPrefabAsset(prefab, AssetDatabase.GetAssetPath(obj));
#else
                PrefabUtility.ReplacePrefab(prefab, obj, ReplacePrefabOptions.ConnectToPrefab);
#endif
            }
            GameObject.DestroyImmediate(prefab);
        }
    }

    private static void ResetChartConfigurations(Object obj)
    {
        var prefab = PrefabUtility.InstantiatePrefab(obj) as GameObject;
        if (prefab != null)
        {
            var chart = prefab.GetComponent<BaseChart>();
            if (chart != null)
            {
                var tooltip = chart.GetChartComponent<Tooltip>();
                if (tooltip != null)
                {
                    tooltip.paddingLeftRight = 10;
                    tooltip.paddingTopBottom = 10;
                }
#if UNITY_2018_3_OR_NEWER
                PrefabUtility.SaveAsPrefabAsset(prefab, AssetDatabase.GetAssetPath(obj));
#else
                PrefabUtility.ReplacePrefab(prefab, obj, ReplacePrefabOptions.ConnectToPrefab);
#endif
            }
            GameObject.DestroyImmediate(prefab);
        }
    }

    private static void SetBackgroundComponent(Object obj)
    {
        var prefab = PrefabUtility.InstantiatePrefab(obj) as GameObject;
        if (prefab != null)
        {
            var chart = prefab.GetComponent<BaseChart>();
            if (chart != null)
            {
                Debug.Log("SetBackgroundComponent:" + AssetDatabase.GetAssetPath(prefab) + "," + chart);
                var background = chart.AddChartComponent<Background>();
                if (background == null) return;
                background.show = true;
                background.borderStyle.show = true;
                background.borderStyle.roundedCorner = true;
                background.borderStyle.cornerRadius = new float[4] { 20, 20, 20, 20 };
#if UNITY_2018_3_OR_NEWER
                PrefabUtility.SaveAsPrefabAsset(prefab, AssetDatabase.GetAssetPath(obj));
#else
                PrefabUtility.ReplacePrefab(prefab, obj, ReplacePrefabOptions.ConnectToPrefab);
#endif
            }
            GameObject.DestroyImmediate(prefab);
        }
    }
}