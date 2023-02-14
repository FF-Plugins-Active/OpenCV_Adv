// Some copyright should be here...

using System;
using System.IO;
using UnrealBuildTool;

public class OpenCV_Adv : ModuleRules
{
	public OpenCV_Adv(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        if (UnrealTargetPlatform.Win64 == Target.Platform)
        {
            string Location_OpenCV = "$(EngineDir)/Plugins/Runtime/OpenCV/Source/ThirdParty/OpenCV/";

            PublicIncludePaths.Add(Path.Combine(Location_OpenCV, "include"));

            PublicAdditionalLibraries.Add(Path.Combine(Location_OpenCV, "lib", "Win64", "opencv_world455.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(Location_OpenCV, "lib", "Win64", "opencv_world455d.lib"));
        }

        PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
                "RenderCore",
				// ... add private dependencies that you statically link with here ...	
			}
            );
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
