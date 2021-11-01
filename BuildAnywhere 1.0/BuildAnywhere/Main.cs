using System;
using System.Threading;
using Harmony;
using UnityEngine;

namespace BuildAnywhere
{
	public class Main
	{
		public static HarmonyInstance harmony;

		public static Thread hotkeys = new Thread(new ThreadStart(Hotkey.Update));

		public static void Load()
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				Log("Loading BuildAnywhere...");

				{

				}
				Settings.i.ParseEnums();
				if (Settings.i.Hotkeys)
				{
				}
				if (Settings.i.VariousTests)
				{
				}
				harmony = HarmonyInstance.Create("com.Fumihiko.BuildAnywhere");
				harmony.PatchAll(typeof(Main).Assembly);
				if (Settings.i.Hotkeys || Settings.i.VariousTests)
				{
					hotkeys.IsBackground = true;
					hotkeys.Start();
				}
			}
			catch (Exception ex)
			{
				Log(ex.ToString());
			}
		}

		public static void Log(string str)
		{
			Debug.Log((object)("[BuildAnywhere] " + str));
		}
	}
}
