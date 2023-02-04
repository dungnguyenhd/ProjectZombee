

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectZombeeEditorTarget : TargetRules
{
	public ProjectZombeeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ProjectZombee" } );
	}
}
