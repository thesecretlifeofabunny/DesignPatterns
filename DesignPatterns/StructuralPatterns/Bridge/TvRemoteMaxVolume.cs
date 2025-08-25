namespace DesignPatterns.StructuralPatterns.Bridge;

public class TvRemoteMaxVolume(IEntertainmentDevice theDevice) : RemoteButton(theDevice)
{
    private IEntertainmentDevice TheDevice { get; } = theDevice;
    
    private const int MaxVolume = 100;

    public override void ButtonNinePressed()
    {
        TheDevice.VolumeSetting = MaxVolume;
        Console.WriteLine("The volume is now maxed out");
    }
    
    public override int GetRemotesMaxSupportedVolume() => MaxVolume;
}