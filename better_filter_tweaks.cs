using HarmonyLib;

namespace better_filters
{
	public class better_filter_tweaks : KMod.UserMod2
	{
		[HarmonyPatch(typeof(AirFilterConfig), "CreateBuildingDef")]
		public class patch_flip_air_filter
		{
			public static void Postfix(BuildingDef __result)
			{
				__result.PermittedRotations = PermittedRotations.R360;
				__result.BuildLocationRule = BuildLocationRule.OnFloorOrBuildingAttachPoint;
			}
		}
	}
}