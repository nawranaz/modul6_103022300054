// See https://aka.ms/new-console-template for more information
class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        this.username = username;
        uploadedVideos = new List<SayaTubeVideo>();

    }

    public int GetTotalVideoPlayCount()
    {
        int count = 0;
        foreach (SayaTubeVideo video in uploadedVideos)

        {

            count += video.GetPlayCount();

        }

        return count;

    }

    public void AddVideo(SayaTubeVideo input)
    {
        uploadedVideos.Add(input);
    }

    public void printAllVideoPlayCount()
    {
        Console.WriteLine("User :" + username);
        for(int i = 0; i > uploadedVideos.Count; i++)
        {
            Console.WriteLine("video" + i + 1 + "judul" + uploadedVideos[i].GetTitle() + "count" + uploadedVideos[i].GetPlayCount());

        }
    }
}

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo (string title)
    {
        this.title = title;
        Random rand = new Random();
        this.id = rand.Next(10000 ,99999);
        this.playCount = 0;
    }
    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void printVideoDetails()
    {
        Console.WriteLine("ID Video: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
    
    public int GetPlayCount()
    {
        return playCount;
    }
    
    public string GetTitle()
    {
        return title;
    }
}

class Program
{
    static void Main()
    {
        SayaTubeUser user1 = new SayaTubeUser("Nawra");
        SayaTubeVideo video1 = new SayaTubeVideo("Inside Out");
        SayaTubeVideo video2 = new SayaTubeVideo("FIlmB");
        SayaTubeVideo video3 = new SayaTubeVideo("FilmC");
        SayaTubeVideo video4 = new SayaTubeVideo("D");
        SayaTubeVideo video5 = new SayaTubeVideo("E");
        SayaTubeVideo video6 = new SayaTubeVideo("F");
        SayaTubeVideo video7 = new SayaTubeVideo("G");
        SayaTubeVideo video8 = new SayaTubeVideo("H");
        SayaTubeVideo video9 = new SayaTubeVideo("I");
        SayaTubeVideo video10 = new SayaTubeVideo("J");

    }
}