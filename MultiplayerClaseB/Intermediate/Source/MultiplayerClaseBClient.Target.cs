using UnrealBuildTool;

public class MultiplayerClaseBClientTarget : TargetRules
{
	public MultiplayerClaseBClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MultiplayerClaseB");
	}
}
