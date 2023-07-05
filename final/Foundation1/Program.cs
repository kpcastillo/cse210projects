using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Black Holes Explained", "In a nutshell", "7:30 Min" );
        Comments comment11 = new Comments("This video is awesome I loved it", "Maria G");
        Comments comment12 = new Comments("Very educational", "Karen P");
        Comments comment13 = new Comments("This video feels sensationalist", "Jay J");
        video1._commentList.Add(comment11);
        video1._commentList.Add(comment12);
        video1._commentList.Add(comment13);
        video1.DisplayVideo();

        Video video2 = new Video("Advanced business analitics", "Simply learn", "7:30:09" );
        Comments comment21 = new Comments("Educational but too long", "Brady L");
        Comments comment22 = new Comments("I spent hours watching this video but it was woth it.", "Leah B");
        Comments comment23 = new Comments("Bad video and too long." , "Jerry F");
        Comments comment24 = new Comments("It started good but got borring", "Ana G");
        video2._commentList.Add(comment21);
        video2._commentList.Add(comment22);
        video2._commentList.Add(comment23);
        video2._commentList.Add(comment24);
        video2.DisplayVideo();

        Video video3 = new Video("Animation Vs Math", "Allan Becker", "14:15 Min" );
        Comments comment31 = new Comments("TSo far, this is the best action movie in 2023!", "V Facts");
        Comments comment32 = new Comments("This man doesn't need an Oscar, the Oscar needs him.", "Kenver Len");
        Comments commenr33 = new Comments("I have NEVER thought about being THAT fascinated by math. What an amazing animation.", "Yuki");
        video3._commentList.Add(comment31);
        video3._commentList.Add(comment32);
        video3._commentList.Add(commenr33);
        video3.DisplayVideo();

    }
}