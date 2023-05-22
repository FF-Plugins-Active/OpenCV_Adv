// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "Kismet/BlueprintFunctionLibrary.h"

// UE Includes.
#include "Engine/TextureRenderTarget2D.h"

#include "OpenCV_AdvBPLibrary.generated.h"

UCLASS()
class UOpenCV_AdvBPLibrary : public UBlueprintFunctionLibrary
{
	GENERATED_UCLASS_BODY()

	UFUNCTION(BlueprintCallable, meta = (DisplayName = "OpenCV QR Detect and Decode", Keywords = "opencv, qr, detect, decode"), Category = "OpenCV_Adv|QR")
	static bool OpenCV_QR_DetectAndDecode(FString& OutQrDecoded, FString& OutCode, UTextureRenderTarget2D* InRT);
};