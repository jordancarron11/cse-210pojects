using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Bank Account";
        video1._length = "180";
        video1._author = "Young Savage";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Jordan Carron";
        video1Comment1._commentText = "Yo this slaps";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Courtni Byun";
        video1Comment2._commentText = "We love you savage!!";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Courtney Tia";
        video1Comment3._commentText = "Great base fam!";

        Video video2 = new Video();
        video2._title = "Cats Attack";
        video2._length = "400";
        video2._author = "KATBOI";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "zeneth";
        video2Comment1._commentText = "Love the second cat so aborable!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Martha bell";
        video2Comment2._commentText = "I would buy all of these if I could!";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Jonas bright";
        video2Comment3._commentText = "cats are the worst!";

        Video video3 = new Video();
        video3._title = "2022 highlights";
        video3._length = "250";
        video3._author = "Andrew Morris";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Amanda Jesse";
        video3Comment1._commentText = "sickkkkkkkk!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Louie Goodman";
        video3Comment2._commentText = "Lets catch up soon man!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "White Goodman";
        video3Comment3._commentText = "Cool trips man!";
    

        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
 
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }

    }
}