using System;
using System.IO;
using Oculus.Newtonsoft.Json;
using UnityEngine;

namespace BuildAnywhere
{
	public class Settings
	{
		[JsonIgnore]
		public KeyCode _ButtonIgnoreBuildArea;

		public string ButtonIgnoreBuildArea;

		[JsonIgnore]
		public KeyCode _ButtonIgnoreBuildOverlap;

		public string ButtonIgnoreBuildOverlap;

		public bool Hotkeys;

		[JsonIgnore]
		public KeyCode _TeleportStone;

		public string TeleportStone;

		[JsonIgnore]
		public KeyCode _TeleportMouse;

		public string TeleportMouse;

		public bool FishingAlwaysSuccess;

		public bool FishAlwaysBiting;

		public bool FishPullAutomatically;

		public bool FishNoDurabiliyLoss;

		public bool AllObjectsNoDurability;

		public bool AutopsyNoConfirm;

		public bool AutoDropIntoStorage;

		public bool AutoDropIntoStoragePlayerStacks;

		public bool AutoDropIntoStoragePlayerAll;

		public bool ZombieDropTechOrbs;

		public bool PGB_global;

		public bool PGB_LinkStorageWellPump;

		public bool PGB_MoreZombieRecipies;

		public bool PGB__AllBuildingsAtAllBlueprintDesks;

		public bool CorpseBuff;

		public bool InfiniteBuffs;

		public bool VariousTests;

		public static Settings i = new Settings();

		public static string Path = System.IO.Path.Combine("QMods", "BuildAnywhere", "settings.json");

		public void ParseEnums()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			Enum.TryParse<KeyCode>(ButtonIgnoreBuildArea, ignoreCase: true, out _ButtonIgnoreBuildArea);
			Enum.TryParse<KeyCode>(ButtonIgnoreBuildOverlap, ignoreCase: true, out _ButtonIgnoreBuildOverlap);
			Enum.TryParse<KeyCode>(TeleportStone, ignoreCase: true, out _TeleportStone);
			Enum.TryParse<KeyCode>(TeleportMouse, ignoreCase: true, out _TeleportMouse);
			Debug.Log((object)$"[BuildAnywhere] Mapping buttons: _ButtonIgnoreBuildArea={i._ButtonIgnoreBuildArea}, _ButtonIgnoreBuildOverlap={_ButtonIgnoreBuildOverlap}, _TeleportStone={_TeleportStone}, _TeleportMouse={_TeleportMouse}");
		}

		public Settings()
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			KeyCode val = (KeyCode)99;
			ButtonIgnoreBuildArea = ((object)(KeyCode)(val)).ToString();
			val = (KeyCode)118;
			ButtonIgnoreBuildOverlap = ((object)(KeyCode)(val)).ToString();
			Hotkeys = true;
			val = (KeyCode)104;
			TeleportStone = ((object)(KeyCode)(val)).ToString();
			val = (KeyCode)103;
			TeleportMouse = ((object)(KeyCode)(val)).ToString();
			FishingAlwaysSuccess = true;
			FishAlwaysBiting = true;
			FishPullAutomatically = true;
			FishNoDurabiliyLoss = true;
			AllObjectsNoDurability = true;
			AutopsyNoConfirm = true;
			AutoDropIntoStorage = true;
			ZombieDropTechOrbs = true;
			PGB_global = true;
			PGB_LinkStorageWellPump = true;
			PGB_MoreZombieRecipies = true;
			CorpseBuff = true;
			InfiniteBuffs = true;
		}
	}
}
