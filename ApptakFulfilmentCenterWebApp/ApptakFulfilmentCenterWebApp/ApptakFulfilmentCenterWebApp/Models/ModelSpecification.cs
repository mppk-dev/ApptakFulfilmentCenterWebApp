using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ModelSpecification
{
    public int? CompanyCode { get; set; }

    public int? CategoryCode { get; set; }

    public int? SubCategoryCode { get; set; }

    public int? BrandCode { get; set; }

    public string? ModelCode { get; set; }

    public string? NetworkTechnology { get; set; }

    public string? NetworkG2Bands { get; set; }

    public string? NetworkG3Bands { get; set; }

    public string? NetworkG4Bands { get; set; }

    public string? NetworkG5Bands { get; set; }

    public string? LaunchAnnounced { get; set; }

    public string? LaunchStatus { get; set; }

    public string? BodyDimensions { get; set; }

    public string? BodyWeight { get; set; }

    public string? BodySim { get; set; }

    public string? BodyDualSim { get; set; }

    public string? DisplayType { get; set; }

    public string? DisplaySize { get; set; }

    public string? DisplayResolution { get; set; }

    public string? DisplayMultitouch { get; set; }

    public string? PlatformOs { get; set; }

    public string? PlatformChipset { get; set; }

    public string? PlatformCpu { get; set; }

    public string? PlatformGpu { get; set; }

    public string? MemoryCardSlot { get; set; }

    public string? MemoryInternal { get; set; }

    public string? MainCameraModules { get; set; }

    public string? MainCameraFeatures { get; set; }

    public string? MainCameraVideo { get; set; }

    public string? SelfieCameraModules { get; set; }

    public string? SelfieCameraFeatures { get; set; }

    public string? SelfieCameraVideo { get; set; }

    public string? SoundAlertTypes { get; set; }

    public string? SoundLoudspeaker { get; set; }

    public string? SoundMmjack { get; set; }

    public string? SoundOthers { get; set; }

    public string? CommsWlan { get; set; }

    public string? CommsBluetooth { get; set; }

    public string? CommsGps { get; set; }

    public string? CommsNfc { get; set; }

    public string? CommsInfraredPort { get; set; }

    public string? CommsRadio { get; set; }

    public string? CommsUsb { get; set; }

    public string? FeaturesSensors { get; set; }

    public string? FeaturesMessaging { get; set; }

    public string? FeaturesBrowser { get; set; }

    public string? FeaturesJava { get; set; }

    public string? FeaturesOthers { get; set; }

    public string? BatteryType { get; set; }

    public string? BatteryStandBy { get; set; }

    public string? BatteryTalkTime { get; set; }

    public string? MiscColor { get; set; }

    public string? UserEntry { get; set; }

    public DateOnly? DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateOnly? DateModify { get; set; }
}
