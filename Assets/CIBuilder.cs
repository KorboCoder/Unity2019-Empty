using UnityEditor;
class CIBuilder
{
    static void PerformBuild()
    {
        string[] scenes = { "Assets/SampleScene.unity" };
        BuildPipeline.BuildPlayer(scenes, "/root/bin", BuildTarget.Android, BuildOptions.None);
    }
}