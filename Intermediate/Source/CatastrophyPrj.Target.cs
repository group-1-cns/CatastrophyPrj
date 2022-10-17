using UnrealBuildTool;

public class CatastrophyPrjTarget : TargetRules
{
	public CatastrophyPrjTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CatastrophyPrj");
	}
}
