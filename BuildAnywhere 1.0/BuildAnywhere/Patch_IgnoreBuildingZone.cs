using Harmony;
using UnityEngine;

namespace BuildAnywhere
{
	[HarmonyPatch(typeof(FlowGridCell), "IsInsideWorldZone", null)]
	public class Patch_IgnoreBuildingZone
	{
		public static bool Prepare()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			return (int)Settings.i._ButtonIgnoreBuildArea > 0;
		}

		public static void Postfix(ref bool __result)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			if (Input.GetKey(Settings.i._ButtonIgnoreBuildArea))
			{
				__result = true;
			}
		}
	}
}
