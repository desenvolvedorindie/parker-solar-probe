using UnrealBuildTool;

public class Solar_System_SimTarget : TargetRules
{
	public Solar_System_SimTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Solar_System_Sim");
	}
}
