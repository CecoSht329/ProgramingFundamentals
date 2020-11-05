using Songs;
using System;
using System.Collections.Generic;
using System.Linq;


class Songs_Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        List<Song> songs = new List<Song>();

        for (int i = 0; i < count; i++)
        {
            string[] inputInfo = Console.ReadLine().Split('_');

            string typeList = inputInfo[0];
            string name = inputInfo[1];
            string time = inputInfo[2];

            Song song = new Song();
            song.TypeList = typeList;
            song.Name = name;
            song.Time = time;

            songs.Add(song);
        }

        string targetListType = Console.ReadLine();
        if (targetListType=="all")
        {
            foreach (var currentSong in songs)
            {
                 Console.WriteLine(currentSong.Name);
            }
        }
        else
        {
            foreach (var currentSong in songs)
            {
                if (currentSong.TypeList == targetListType)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
        }
        ////1 example
        //foreach (var currentSong in songs)
        //{
        //    if (currentSong.TypeList == targetListType)
        //    {
        //        Console.WriteLine(currentSong.Name);
        //    }
        //}

        ////2 example
        //songs = songs.FindAll(x => x.TypeList == targetListType);

        //foreach (var currentSong in songs)
        //{
        //    Console.WriteLine(currentSong.Name);
        //}

        ////3 example
        //songs
        //    .Where(x => x.TypeList == targetListType).ToList().ForEach(x => Console.WriteLine(x.Name));
    }

}
