namespace DesignPatterns.StructuralPatterns.Bridge;

/// <summary>
/// I used the example from the following IEEE cited source.
/// My code is essentially a copy to further ground the learning I did from the video.
///  “ Bridge Design Pattern .” YouTube, YouTube, 1 Oct. 2012, www.youtube.com/watch?v=9jIgSsIfh_8.
/// </summary>
public class TvRemoteMute(IEntertainmentDevice theDevice) : RemoteButton(theDevice)
{
    private IEntertainmentDevice TheDevice { get; } = theDevice;

    private const int MaxVolume = 100;

    public override int GetRemotesMaxSupportedVolume() => MaxVolume;

    public override void ButtonNinePressed()
    {
        TheDevice.VolumeSetting = 0;

        Console.WriteLine("Tv was muted");
    }
}