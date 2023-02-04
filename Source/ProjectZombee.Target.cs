

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectZombeeTarget : TargetRules
{
	public ProjectZombeeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

        bUsesSteam = true;

        ExtraModuleNames.AddRange( new string[] { "ProjectZombee" } );
	}
}
