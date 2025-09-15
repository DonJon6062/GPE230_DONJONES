// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GPE230_DONJONES : ModuleRules
{
	public GPE230_DONJONES(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GPE230_DONJONES",
			"GPE230_DONJONES/Variant_Platforming",
			"GPE230_DONJONES/Variant_Platforming/Animation",
			"GPE230_DONJONES/Variant_Combat",
			"GPE230_DONJONES/Variant_Combat/AI",
			"GPE230_DONJONES/Variant_Combat/Animation",
			"GPE230_DONJONES/Variant_Combat/Gameplay",
			"GPE230_DONJONES/Variant_Combat/Interfaces",
			"GPE230_DONJONES/Variant_Combat/UI",
			"GPE230_DONJONES/Variant_SideScrolling",
			"GPE230_DONJONES/Variant_SideScrolling/AI",
			"GPE230_DONJONES/Variant_SideScrolling/Gameplay",
			"GPE230_DONJONES/Variant_SideScrolling/Interfaces",
			"GPE230_DONJONES/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
