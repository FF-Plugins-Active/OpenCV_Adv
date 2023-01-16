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

        if (UnrealTargetPlatform.Android == Target.Platform)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "include"));

            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libade.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libcpufeatures.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libIlmImf.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libittnotify.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "liblibjpeg-turbo.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "liblibopenjp2.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "liblibpng.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "liblibprotobuf.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "liblibtiff.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "liblibwebp.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_calib3d.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_core.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_dnn.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_features2d.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_flann.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_gapi.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_highgui.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_imgcodecs.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_imgproc.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_ml.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_objdetect.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_photo.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_stitching.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_video.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_videoio.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libquirc.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libtbb.a"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libtegra_hal.a"));

            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "ThirdParty", "OpenCV_4.5.5", "Android", "lib", "libopencv_java4.so"));

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
