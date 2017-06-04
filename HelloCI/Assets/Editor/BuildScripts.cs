using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.Diagnostics;
using System.IO;

public class BuildScripts {

	[PostProcessBuildAttribute(1)]
	public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject) {
		UnityEngine.Debug.Log( pathToBuiltProject );




		DirectoryInfo folder = Directory.CreateDirectory(pathToBuiltProject + "/../TestFolder" );
		string s = folder.FullName + "/a.out";
		UnityEngine.Debug.Log(s );
		System.IO.File.WriteAllText (s, "Hello\nWorld\npathToBuiltProject: " + pathToBuiltProject);
//		ProcessStartInfo psi = new ProcessStartInfo(); 
//		psi.FileName = "/bin/sh";
//		psi.UseShellExecute = false; 
//		psi.RedirectStandardOutput = true;
//		psi.Arguments = Application.dataPath + "/test.sh" + " arg1 arg2 arg3";

//		var proc = new Process {
//			StartInfo = new ProcessStartInfo {
//				FileName = "dir.exe",
//				Arguments = "\\",
//				UseShellExecute = false,
//				RedirectStandardOutput = true,
//				CreateNoWindow = true
//			}
//		};
//		proc.Start();
//		while (!proc.StandardOutput.EndOfStream) {
//			string line = proc.StandardOutput.ReadLine();
//			UnityEngine.Debug.Log (line);
//		}
	}


	public static void PostBuild(string path) {
		DirectoryInfo folder = Directory.CreateDirectory(path + "/../TestFolder2" );
		string s = folder.FullName + "/b.out";
		UnityEngine.Debug.Log(s );
		System.IO.File.WriteAllText (s, "Hello\nWorld\npath: " + path);

	}
}
