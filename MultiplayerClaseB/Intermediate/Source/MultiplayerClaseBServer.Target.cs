using UnrealBuildTool;

public class MultiplayerClaseBServerTarget : TargetRules
{
	public MultiplayerClaseBServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MultiplayerClaseB");
	}
}
