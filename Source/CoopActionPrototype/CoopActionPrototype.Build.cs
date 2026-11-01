// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CoopActionPrototype : ModuleRules
{
	public CoopActionPrototype(ReadOnlyTargetRules Target) : base(Target)
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
			"CoopActionPrototype",
			"CoopActionPrototype/Variant_Platforming",
			"CoopActionPrototype/Variant_Platforming/Animation",
			"CoopActionPrototype/Variant_Combat",
			"CoopActionPrototype/Variant_Combat/AI",
			"CoopActionPrototype/Variant_Combat/Animation",
			"CoopActionPrototype/Variant_Combat/Gameplay",
			"CoopActionPrototype/Variant_Combat/Interfaces",
			"CoopActionPrototype/Variant_Combat/UI",
			"CoopActionPrototype/Variant_SideScrolling",
			"CoopActionPrototype/Variant_SideScrolling/AI",
			"CoopActionPrototype/Variant_SideScrolling/Gameplay",
			"CoopActionPrototype/Variant_SideScrolling/Interfaces",
			"CoopActionPrototype/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
