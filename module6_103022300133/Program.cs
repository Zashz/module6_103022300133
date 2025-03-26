
class SayaTubeUser {
    private int id;
    private List<SayaTubeVideo> uploaded;
    string username;

    public SayaTubeUser(string username)
    {
        this.username = username;
        this.uploaded = new List<SayaTubeVideo>();
    }
    
    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (SayaTubeVideo video in uploaded)
        {
            totalPlayCount += video.IncreasePlayCount();
        }
        return totalPlayCount;
    }


    public void AddVideos(SayaTubeVideo) { 
        
    }

    public void PrintAllVideoPlaycount(){
        Console.WriteLine("User: <" + username + ">");
        for (int i = 0; i < uploaded.Count; i++)
        {
            Console.WriteLine("Video: <" + uploaded[i].title + ">");
        }
    }
}

class SayaTubeVideo { 
    private int id;
    private string title;
    int playCount;

    public SayaTubeVideo(string title)
    {
        this.title = title;
        Random id = new Random();

    }

    public void IncreasePlayCount(int playcount) { 
        this.playCount = playcount;
    }

    public void PrintVideoDetails() {
        Console.WriteLine("ID: <" + id + ">");
        Console.WriteLine("Title: <" + title + ">");
        Console.WriteLine("Play Count: <" + playCount + ">");
    }
    
}
