using UnityEditor;
using UnityEngine;

public class TestBuilder : EditorWindow
{

    [MenuItem("CustomBuild/Build")]    

    static void TestBuild()
    {
        AndroidBuild();       
    }
    

    static void AndroidBuild()
    {
        BuildPipeline.BuildAssetBundles("AssetBundles", BuildAssetBundleOptions.None, BuildTarget.Android);

        var scenes = EditorBuildSettings.scenes;

        BuildPipeline.BuildPlayer(scenes, "Build/Test.apk", BuildTarget.Android, BuildOptions.None);


    }

}