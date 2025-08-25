namespace DesignPatterns.StructuralPatterns.Bridge;

/// <summary>
/// I used the example from the following IEEE cited source.
/// My code is essentially a copy to further ground the learning I did from the video.
///  “ Bridge Design Pattern .” YouTube, YouTube, 1 Oct. 2012, www.youtube.com/watch?v=9jIgSsIfh_8.
/// </summary>
public interface IEntertainmentDevice
{
    public int DeviceState { get; set; }
    public int MaxSetting { get; }
    public int VolumeSetting { get; set; }

    public void ButtonFivePressed();
    public void ButtonSixPressed();

    public void DeviceFeedback()
    {
        var isDeviceStateOutOfBounds = DeviceState > MaxSetting || DeviceState < 0;
        if (isDeviceStateOutOfBounds) DeviceState = 0;
        
        Console.WriteLine($"The device state is {DeviceState}");
    }

    public void ButtonSevenPressed()
    {
        VolumeSetting++;
        Console.WriteLine($"The volume is now at {VolumeSetting}");
    }
    
    public void ButtonEightPressed()
    {
        VolumeSetting--;
        Console.WriteLine($"The volume is now at {VolumeSetting}");
    }
}