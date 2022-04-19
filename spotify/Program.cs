using System;

namespace spotify
{
    class Player
    {
        static Person ik = new Person("ik", "ik@gmail.com");
        static Artist ed_sheeran = new Artist("Ed Sheeran", "edsheeran@gmail.com");
        static Album devidedDeluxe = new Album("album", "/(deluxe)", "pop", "19-04-2022", ed_sheeran);
        static Album equals = new Album("album", "/(deluxe)", "pop", "19-04-2022", ed_sheeran);
        static Album five = new Album("album", "/(deluxe)", "pop", "19-04-2022", ed_sheeran);
        static Song Castle_on_the_hill = new Song("Castle on the hill", 261, ed_sheeran, "pop");
        static Song bad_habits = new Song("Bad Habits", 230, ed_sheeran, "pop");
        static Song shivers = new Song("Shivers", 202, ed_sheeran, "pop");
        static Song perfect = new Song("Perfect", 263, ed_sheeran, "pop");
        static Song shape_of_you = new Song("Shape of You", 233, ed_sheeran, "pop");
        static Song so = new Song("So", 268, ed_sheeran, "pop");
        static Song the_city = new Song("The City", 266, ed_sheeran, "pop");
        static void Main(string[] args)
        {
            
            Playlist test = new Playlist("test1", true, ik);
            Playlist test2 = new Playlist("test2", true, ik);
            ik.addPlaylist(test);
            ik.addPlaylist(test2);
            ik.printPlaylists();
            devidedDeluxe.addSong(Castle_on_the_hill);
            devidedDeluxe.addSong(perfect);
            devidedDeluxe.addSong(shape_of_you);
            equals.addSong(shivers);
            equals.addSong(bad_habits);
            five.addSong(so);
            five.addSong(the_city);

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }


        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Play something");
            Console.WriteLine("2) playlists");
            Console.WriteLine("3) Friends");
            Console.WriteLine("4) Control current music");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    PlaySomething();
                    return true;
                case "2":
                    Playlists();
                    return true;
                case "3":
                    /*Friends();*/
                    return true;
                case "4":
                    /*ControlMusic();*/
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        static void Playlists()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Show playlists");
            Console.WriteLine("2) Select Playlist");
            Console.WriteLine("3) Add Playlist");
            Console.WriteLine("4) Remove Playlist");
            Console.WriteLine("5) Back");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ShowPlaylists();
                    return;
                case "2":
                    /*SelectPlaylist();*/
                    return;
                case "3":
                    /*AddPlaylist();*/
                    return;
                case "4":
                    /*RemovePlaylist();*/
                    return;
                case "5":
                    MainMenu();
                    return;
            }
        }

        static void ShowPlaylists()
        {
            ik.printPlaylists();
            Console.WriteLine("\r\nPress any key to continue...");
            Console.ReadKey();

        }

        static void PlaySomething()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Play a song");
            Console.WriteLine("2) Play a playlist");
            Console.WriteLine("3) Play a album");
            Console.WriteLine("4) Back");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    PlaySong();
                    return;
                case "2":
                    /*PlayPlaylist();*/
                    return;
                case "3":
                    PlayAlbum();
                    return;
                case "4":
                    MainMenu();
                    return;
            }
        }

        static void PlaySong()
        {

        }

        static void PlayAlbum()
        {
            Console.Clear();
            Console.WriteLine("Choose an album:");
            Console.WriteLine("1) /(deluxe)");
            Console.WriteLine("2) =");
            Console.WriteLine("3) 5");
            Console.WriteLine("4) Back");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AlbumDetail(devidedDeluxe);
                    return;
                case "2":
                    AlbumDetail(equals);
                    return;
                case "3":
                    AlbumDetail(five);
                    return;
                case "4":
                    PlaySomething();
                    return;
            }
        }

        static void AlbumDetail(Album album)
        {
            Console.Clear();
            album.printlist();
            Console.WriteLine("");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Play " + album.getname() + " normaly");
            Console.WriteLine("2) Play " + album.getname() + " shuffled");
            Console.WriteLine("3) Back");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    /*PlayAlbum album*/
                    return;
                case "2":
                    /*PlayAlbumShuffled*/
                    return;
                case "3":
                    PlayAlbum();
                    return;
            }

        }
    }
}