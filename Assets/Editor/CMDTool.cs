using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEditor.SceneManagement;


public class CMDTool  {

	[MenuItem("Tools/Build Android")]
	public static void BuildAndroid()
	{
		string app_name = "abc.apk";
		string applicationPath = Application.dataPath.Replace("/Assets", "/apk");

		PlayerSettings.companyName = "xiaopan";
		PlayerSettings.productName = "AutoPublicPackage";
		PlayerSettings.bundleIdentifier = "com.xiaopan.AutoPublicPackage";
		PlayerSettings.bundleVersion = "1.0";

		EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);

		BuildPipeline.BuildPlayer(new string[]{"Assets/Scenes/Main.unity"}, 
			applicationPath+"/"+app_name, BuildTarget.Android, BuildOptions.None);
	}

}
