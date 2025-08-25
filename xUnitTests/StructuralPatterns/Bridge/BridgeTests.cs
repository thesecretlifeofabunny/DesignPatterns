using DesignPatterns.StructuralPatterns.Bridge;

namespace xUnitTests.StructuralPatterns.Bridge;

/// <summary>
/// I used the example from the following IEEE cited source.
/// My code is essentially a copy to further ground the learning I did from the video.
///  “ Bridge Design Pattern .” YouTube, YouTube, 1 Oct. 2012, www.youtube.com/watch?v=9jIgSsIfh_8.
/// </summary>
public class BridgeTests
{
    [Fact]
    public void RemoteButton_TestTvMute_TvShouldBeMutedWithCorrectButtonpress()
    {
        // Arrange
        const int maxSetting = 200;
        const int deviceState = 1;
        RemoteButton theRemoteForTheTv = new TvRemoteMute(new TvDevice(deviceState, maxSetting));
        
        // Act
        theRemoteForTheTv.ButtonFivePressed();
        theRemoteForTheTv.ButtonSixPressed();
        theRemoteForTheTv.ButtonNinePressed();
        
        // Assert
        Assert.Equal(0, theRemoteForTheTv.DeviceVolume());
    }
    
    [Fact]
    public void RemoteButton_TestTvMaxVolume_TvShouldBeAtMaxVolumeWithCorrectButtonpress()
    {
        // Arrange
        const int maxSetting = 200;
        const int deviceState = 1;
        RemoteButton theRemoteForTheTv = new TvRemoteMaxVolume(new TvDevice(deviceState,maxSetting));
        
        // Act
        theRemoteForTheTv.ButtonFivePressed();
        theRemoteForTheTv.ButtonSixPressed();
        theRemoteForTheTv.ButtonNinePressed();
        
        // Assert
        Assert.Equal(theRemoteForTheTv.GetRemotesMaxSupportedVolume() , theRemoteForTheTv.DeviceVolume());
    }
}