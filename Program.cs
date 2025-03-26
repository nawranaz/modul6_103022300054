// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Diagnostics.Contracts;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        Debug.Assert(!string.IsNullOrEmpty(username) && username.Length <= 200, "Username memiliki panjang maksimal 100 karakter dan tidak berupa null.");
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
        Contract.Requires(input != null);
        uploadedVideos.Add(input);
    }

    public void printAllVideoPlayCount()
    {
        Console.WriteLine("User :" + username);
        for(int i = 0; i > 7; i++)
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
        Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 200, "Judul video memiliki panjang maksimal 200 karakter dan tidak berupa null.");
        this.title = title;
        Random rand = new Random();
        this.id = rand.Next(10000 ,99999);
        this.playCount = 0;
    }
    public void IncreasePlayCount(int playCount)
    {
        Debug.Assert(playCount > 0 && playCount <= 25000000, "Input penambahan play count maksimal 25.000.000 per panggilan method-nya");
        try
        {
            checked
            {
                this.playCount += playCount;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Plauy count melebihi batas maksimum.");
        }
            
      
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

        user1.AddVideo(video1);
        user1.AddVideo(video2);
        user1.AddVideo(video3);
        user1.AddVideo(video4);
        user1.AddVideo(video5);
        user1.AddVideo(video6);
        user1.AddVideo(video7);
        user1.AddVideo(video8);
        user1.AddVideo(video9);
        user1.AddVideo(video10);
        user1.printAllVideoPlayCount();

        for (int i = 0; i < 10; i++)
        {
            video1.IncreasePlayCount(1000000);
        }
    }
}