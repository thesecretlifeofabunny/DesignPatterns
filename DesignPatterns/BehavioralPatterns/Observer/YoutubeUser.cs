namespace DesignPatterns.BehavioralPatterns.Observer;

public class YoutubeUser
{
    public List<Youtuber> SubscribedTo { get; set; } = [];

    public List<(string, string)> VideoNotification { get; set; } = [];

    public void NotifyOfVideo(string youtuberName, string video) => VideoNotification.Add((youtuberName, video));

    public List<(string, string)> ConsumeNotification()
    {
        var notificationsList = VideoNotification;
        VideoNotification = [];
        return notificationsList;
    }
}