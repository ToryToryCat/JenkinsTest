using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildScript2
{
    public static void BuildAndroid()
    {
        //EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);

        string[] scenes = {
            "Assets/Scenes/SampleScene.unity",
        };

        string outputPath1 = "Builds/Android/MyGame2.apk";  // 출력 위치

        string directory = Path.GetDirectoryName(outputPath1);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
            Debug.Log("🔧 Build output directory created: " + directory);
        }

        EditorUserBuildSettings.buildAppBundle = false;

        //키스토어 설정
        //PlayerSettings.Android.useCustomKeystore = true;
        //PlayerSettings.Android.keystoreName = "dancingkong.keystore"; // 키스토어 파일명
        //PlayerSettings.Android.keystorePass = "dancingkong";
        //PlayerSettings.Android.keyaliasName = "dancingkong";
        //PlayerSettings.Android.keyaliasPass = "dancingkong";

        BuildPlayerOptions buildOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = outputPath1,
            target = BuildTarget.Android,
            options = BuildOptions.None
        };

        BuildPipeline.BuildPlayer(buildOptions);
    }
}
