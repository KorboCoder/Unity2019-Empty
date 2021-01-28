using UnityEditor;
class CIBuilder
{
    static void PerformBuild()
    {
        string[] scenes = { "Assets/SampleScene.unity" };
        BuildPipeline.BuildPlayer(scenes, "project/bin/test", BuildTarget.Android, BuildOptions.None);
    }
}
