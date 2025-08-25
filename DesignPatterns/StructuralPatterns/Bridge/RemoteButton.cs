namespace DesignPatterns.StructuralPatterns.Bridge;

/// <summary>
/// I used the example from the following IEEE cited source.
/// My code is essentially a copy to further ground the learning I did from the video.
///  “ Bridge Design Pattern .” YouTube, YouTube, 1 Oct. 2012, www.youtube.com/watch?v=9jIgSsIfh_8.
/// </summary>
public abstract class RemoteButton(IEntertainmentDevice theDevice)
{
    private IEntertainmentDevice TheDevice { get; } = theDevice;

    public abstract void ButtonNinePressed();

    public abstract int GetRemotesMaxSupportedVolume();
    public void ButtonFivePressed() => TheDevice.ButtonFivePressed();

    public void ButtonSixPressed() => TheDevice.ButtonSixPressed();

    public int DeviceVolume() => TheDevice.VolumeSetting;

    public void DeviceFeedback() => TheDevice.DeviceFeedback();
}