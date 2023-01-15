// Copyright Epic Games, Inc. All Rights Reserved.

#include "OpenCV_AdvBPLibrary.h"
#include "OpenCV_Adv.h"

// UE Includes.
#include "Engine/Texture2D.h"
#include "Kismet/KismetRenderingLibrary.h"

THIRD_PARTY_INCLUDES_START
// OpenCV Includes.
#include <opencv2/objdetect.hpp>
#include "opencv2/highgui.hpp"
#include "opencv2/imgproc.hpp"
#include "opencv2/dnn/dnn.hpp"
#include "opencv2/opencv.hpp"
THIRD_PARTY_INCLUDES_END

UOpenCV_AdvBPLibrary::UOpenCV_AdvBPLibrary(const FObjectInitializer& ObjectInitializer)
: Super(ObjectInitializer)
{

}

bool UOpenCV_AdvBPLibrary::OpenCV_QR_DetectAndDecode(FString& OutQrDecoded, FString& OutCode, UTextureRenderTarget2D* InRT)
{
	if (IsValid(InRT) == false)
	{
		OutCode = "Render target is not valid !";
		return false;
	}

	if (InRT->RenderTargetFormat != ETextureRenderTargetFormat::RTF_RGBA8)
	{
		OutCode = "Render target format is not RTF_RGBA8 !";
		return false;
	}

	TArray<FColor> Pixels;
	UKismetRenderingLibrary::ReadRenderTarget(GEngine->GetCurrentPlayWorld(), InRT, Pixels, true);
	
	cv::Mat Image(cv::Size(InRT->SizeX, InRT->SizeY), CV_8UC4, Pixels.GetData());
	cv::Mat Points;
	cv::Mat Output;
	
	cv::QRCodeDetector QR_Detector = cv::QRCodeDetector::QRCodeDetector();
	std::string Result = QR_Detector.detectAndDecode(Image, Points, Output);

	if (Result.length() > 0)
	{
		OutQrDecoded = Result.c_str();
		OutCode = "Read Sucessful";
		return true;
	}

	else
	{
		OutCode = "Unable to read QR Code";
		return false;
	}
}

