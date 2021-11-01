using Harmony;
using UnityEngine;

namespace BuildAnywhere
{
	[HarmonyPatch(typeof(FloatingWorldGameObject), "RecalculateAvailability", null)]
	public class Patch_IgnoreOverlap
	{
		public static bool Prepare()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			return (int)Settings.i._ButtonIgnoreBuildOverlap > 0;
		}

		public static void Postfix()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			if (Input.GetKey(Settings.i._ButtonIgnoreBuildOverlap))
			{
				FloatingWorldGameObject.can_be_built = true;
			}
		}
	}
}
