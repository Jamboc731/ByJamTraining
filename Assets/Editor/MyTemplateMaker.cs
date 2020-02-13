using UnityEditor;
using System.IO;

public class MyTemplateMaker
{
    public const string PATH_TO_MYSCRIPT_TEMPLATE = @"81-C# Script-JamieBehaviourScript.cs";

    [MenuItem("Assets/Create/JamieScriptTemplate", priority = 82)]
    public static void CreateCustomScript(MenuCommand cmd)
    {


        ProjectWindowUtil.CreateAsset(new MonoScript(), "NewScript.cs");



    }
}