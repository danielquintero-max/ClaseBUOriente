using UnrealBuildTool;

public class MultiplayerClaseBEditorTarget : TargetRules
{
	public MultiplayerClaseBEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MultiplayerClaseB");
	}
}
