using System;

namespace LearningCSharp.EventsAndDelages;

public delegate void NotificationHandler(string videoTitle);

public class YoutubeChannel(string channelName)
{
    public string ChannelName {get;} = channelName;

    public event NotificationHandler? NewVideoPublished;

    public void UploadVideo(string title)
    {
        Console.WriteLine($"\n[{ChannelName}] just uploaded a new video: '{title}'!");
        
        NewVideoPublished?.Invoke(title);
    }
}

public class Subscriber(string name)
{
    public string Name { get; } = name;
  public void ReceiveNotification(string videoTitle)
    {
        Console.WriteLine($"   -> [Notification sent to {Name}]: Hey! A new video is out: '{videoTitle}'");
    }


}

public class Events
{
    public static void Run()
    {
        // Create the channel
        YoutubeChannel techChannel = new("Tech Tips C#");

        // Create two separate subscribers
        Subscriber user1 = new("Alice");
        Subscriber user2 = new("Bob");

        // 👍 LEGAL: Subscribers plug their functions into the event list using +=
        techChannel.NewVideoPublished += user1.ReceiveNotification;
        techChannel.NewVideoPublished += user2.ReceiveNotification;

        // ❌ COMPILE ERROR: The compiler blocks this! 
        // Bob cannot accidentally kick Alice out of the subscriber list.
        // techChannel.NewVideoPublished = user2.ReceiveNotification;

        // ❌ COMPILE ERROR: The compiler blocks outside execution!
        // Alice cannot force the channel to send a fake alert.
        // techChannel.NewVideoPublished("Fake Video Hack");

        // 👍 LEGAL: The channel naturally uploads a video and alerts the list
        techChannel.UploadVideo("Mastering C# Events in 10 Minutes");

        // Alice decides to unsubscribe
        techChannel.NewVideoPublished -= user1.ReceiveNotification;

        // Another video upload! Only Bob will get this one.
        techChannel.UploadVideo("Introduction to Async/Await");
    }
}