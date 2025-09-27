using DesignPatterns.BehavioralPatterns.Observer;

namespace xUnitTests.BehavioralPatterns;

public class ObserverTests
{
    [Fact]
    public void Observer_UserSubscribesToYoutuber_YoutuberHasOneSubscriber()
    {
        // Arrange
        Youtuber bashibunni = new("bashibunni");
        YoutubeUser linusTorvalds = new();
        
        // Act
        bashibunni.SubscribeToYoutuber(linusTorvalds);
        
        // Assert
        Assert.Equal(1, bashibunni.SubscriberCount);
    }
    
    [Fact]
    public void Observer_TwoUsersSubscribesToYoutuber_YoutuberHasTwoSubscriber()
    {
        // Arrange
        Youtuber bashibunni = new("bashibunni");
        YoutubeUser linusTorvalds = new();
        YoutubeUser margaretHamilton  = new();
        
        // Act
        bashibunni.SubscribeToYoutuber(linusTorvalds);
        bashibunni.SubscribeToYoutuber(margaretHamilton);
        
        // Assert
        Assert.Equal(2, bashibunni.SubscriberCount);
    }
    
    [Fact]
    public void Observer_YoutuberPublishesVideo_SubscribersHaveNotificationsOfVideo()
    {
        // Arrange
        Youtuber bashibunni = new("bashibunni");
        YoutubeUser linusTorvalds = new();
        YoutubeUser margaretHamilton  = new();
        bashibunni.SubscribeToYoutuber(linusTorvalds);
        bashibunni.SubscribeToYoutuber(margaretHamilton);

        // Act
        bashibunni.UploadVideo("coding vlog gone wrong… now I'm on NixOS?? (worth it)");     
        
        // Assert
        Assert.Single(linusTorvalds.VideoNotification);
        Assert.Single(margaretHamilton.VideoNotification);
    }

    [Fact]
    public void Observer_YoutuberPublishesVideo_SubscribersCanConsumeNotificationsOfVideoUpload()
    {
        // Arrange
        const string youtuberUsername = "bashibunni";
        Youtuber bashibunni = new(youtuberUsername);
        YoutubeUser linusTorvalds = new();
        YoutubeUser margaretHamilton = new();
        bashibunni.SubscribeToYoutuber(linusTorvalds);
        bashibunni.SubscribeToYoutuber(margaretHamilton);
        const string videoUploaded = "coding vlog gone wrong… now I'm on NixOS?? (worth it)";
        bashibunni.UploadVideo(videoUploaded);
        (string, string) youtubersVideo = (youtuberUsername, videoUploaded);

        // Act
        var linusTorvaldsNotifications = linusTorvalds.ConsumeNotification();
        var margaretHamiltonsNotifications = margaretHamilton.ConsumeNotification();

        // Assert
        Assert.Single(linusTorvaldsNotifications);
        Assert.Single(linusTorvaldsNotifications);
        Assert.Equal(youtubersVideo, linusTorvaldsNotifications.First());
        Assert.Equal(youtubersVideo, margaretHamiltonsNotifications.First());
    }
}