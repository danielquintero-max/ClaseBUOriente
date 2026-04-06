using UnrealBuildTool;

public class MultiplayerClaseBTarget : TargetRules
{
	public MultiplayerClaseBTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MultiplayerClaseB");
	}
}
