namespace DesignPatterns.StructuralPatterns.Bridge;

/// <summary>
/// I used the example from the following IEEE cited source.
/// My code is essentially a copy to further ground the learning I did from the video.
///  “ Bridge Design Pattern .” YouTube, YouTube, 1 Oct. 2012, www.youtube.com/watch?v=9jIgSsIfh_8.
/// </summary>
public class TvDevice(int deviceState, int maxSetting) : IEntertainmentDevice
{
    public int DeviceState { get; set; } = deviceState;
    public int MaxSetting { get; set; } = maxSetting;
    public int VolumeSetting { get; set; }
    
    public void ButtonFivePressed()
    {
        DeviceState--;
        Console.WriteLine("Channel down");
    }

    public void ButtonSixPressed()
    {
        DeviceState++;
        Console.WriteLine("Channel Up");
    }
}