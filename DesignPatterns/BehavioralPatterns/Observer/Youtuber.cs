namespace DesignPatterns.BehavioralPatterns.Observer;

public class Youtuber( string username)
{
    public string Username { get; set; } = username;
    private List<YoutubeUser> Subscribers { get; set; } = [];
    public int SubscriberCount => Subscribers.Count;

    public void SubscribeToYoutuber(YoutubeUser subscriber) => Subscribers.Add(subscriber);

    public void UploadVideo(string videoTitle)
    {
        foreach (var subscriber in Subscribers)
        {
            subscriber.NotifyOfVideo(Username, videoTitle);
        }
    }
}