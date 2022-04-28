using System;

namespace spotify
{
    class Player
    {
        static Person ik = new Person("ik", "ik@gmail.com");
        static Person gast = new Person("gast", "gast@gmail.com");
        static Person dude = new Person("dude", "dude@gmail.com");
        static Person buddy = new Person("buddy", "buddy@gmail.com");
        static Person joch = new Person("joch", "joch@gmail.com");
        static Artist ed_sheeran = new Artist("Ed Sheeran", "edsheeran@gmail.com");
        static Album devidedDeluxe = new Album(0, "album", "/(deluxe)", "pop", "19-04-2022", ed_sheeran);
        static Album equals = new Album(0, "album", "/(deluxe)", "pop", "19-04-2022", ed_sheeran);
        static Album five = new Album(0, "album", "/(deluxe)", "pop", "19-04-2022", ed_sheeran);
        static Song Castle_on_the_hill = new Song("Castle on the hill", 261, ed_sheeran, "pop");
        static Song bad_habits = new Song("Bad Habits", 230, ed_sheeran, "pop");
        static Song shivers = new Song("Shivers", 202, ed_sheeran, "pop");
        static Song perfect = new Song("Perfect", 263, ed_sheeran, "pop");
        static Song shape_of_you = new Song("Shape of You", 233, ed_sheeran, "pop");
        static Song so = new Song("So", 268, ed_sheeran, "pop");
        static Song the_city = new Song("The City", 266, ed_sheeran, "pop");
        static Iplayable current;
        static List<Song> playing = new List<Song>();
        static Playlist list4 = new Playlist(0, "list4", true, gast);
        static Playlist list5 = new Playlist(0, "list5", true, dude);
        static Playlist list6 = new Playlist(0, "list6", true, buddy);
        static Playlist list7 = new Playlist(0, "list7", true, joch);
        static Playlist list8 = new Playlist(0, "list8", true, joch);
        static bool paused = false;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title = "Spotify";

            Playlist test = new Playlist(0, "test1", true, ik);
            Playlist test2 = new Playlist(0, "test2", true, ik);
            ik.addPlaylist(test);
            ik.addPlaylist(test2);
            ik.printPlaylists();
            gast.addPlaylist(list4);
            dude.addPlaylist(list5);
            buddy.addPlaylist(list6);
            joch.addPlaylist(list7);
            joch.addPlaylist(list8);
            list4.addSong(Castle_on_the_hill);
            list5.addSong(bad_habits);
            list6.addSong(shivers);
            list7.addSong(perfect);
            list8.addSong(shape_of_you);
            list4.addSong(so);
            list5.addSong(the_city);
            list6.addSong(the_city);
            list7.addSong(the_city);
            list8.addSong(the_city);
            devidedDeluxe.addSong(Castle_on_the_hill);
            devidedDeluxe.addSong(perfect);
            devidedDeluxe.addSong(shape_of_you);
            equals.addSong(shivers);
            equals.addSong(bad_habits);
            five.addSong(so);
            five.addSong(the_city);


            current = Castle_on_the_hill;
 
            current = five;

            current = test;





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
            Console.WriteLine("2) Playlists");
            Console.WriteLine("3) Friends");
            Console.WriteLine("4) Control current music");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    PlaySomething(); /*dit is af denk*/
                    return true;
                case "2":
                    Playlists(); /*dit is af*/
                    return true;
                case "3":
                    Friends(); /*dit is af*/
                    return true;
                case "4":
                    ControlMusic(); /*hier moet nog veel aan gebeuren*/
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        static void ControlMusic()
        {
            Console.Clear();
            int i = 0;
            foreach (Song song in playing)
            {
                if (i == 0)
                {
                    Console.WriteLine("Playing: " + song.getTitle());
                    Console.Write("Next: ");
                }
                else
                {
                    Console.WriteLine(" " + song.getTitle());
                }
                i++;
            }
            Console.WriteLine("\n\nChoose an option:");
            if (paused == false)
            {
                Console.WriteLine("1) Pause");
            }
            else
            {
                Console.WriteLine("1) Resume");
            }
            Console.WriteLine("2) Skip");
            Console.WriteLine("3) Stop music");
            Console.WriteLine("4) Back");

            switch (Console.ReadLine())
            {
                case "1":
                    if (paused == false)
                    {
                        paused = true;
                        Console.WriteLine("Music is paused");
                    }
                    else
                    {
                        paused = false;
                        Console.WriteLine("Music is resumed");
                    }
                    break;
                case "2":
                    if (playing.Count >= 1)
                    {
                        current = playing[1];
                        playing.RemoveAt(0);
                        Console.WriteLine("Music is skipped");
                    }
                    else
                    {
                        Console.WriteLine("No songs are playing.");
                    }
                    break;
                case "3":
                    if (playing.Count >= 1)
                    {
                        current = null;
                        playing.Clear();
                        Console.WriteLine("Music is stopped");
                    }
                    else
                    {
                        Console.WriteLine("No songs are playing.");
                    } 
                    break;
                case "4":
                    return;
                default:
                    ControlMusic();
                    break;
            }
            Console.ReadKey();
        }


        static void Friends()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add a friend");
            Console.WriteLine("2) Remove a friend");
            Console.WriteLine("3) Show friends");
            Console.WriteLine("4) Back");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddFriend();
                    return;
                case "2":
                    RemoveFriend();
                    return;
                case "3":
                    ShowFriends();
                    return;
                case "4":
                    MainMenu();
                    return;
                default:
                    Friends();
                    return;
            }
        }

        static void AddFriend()
        {
            Console.Clear();
            Console.WriteLine("People you could add: " + gast.getName() + ", " + dude.getName() + ", " + buddy.getName() + ", " + joch.getName());
            Console.WriteLine("Enter the name of the friend you want to add:");
            string name = Console.ReadLine();
            if (name == "ik")
            {
                Console.WriteLine("You can't add yourself as a friend.");
                Console.ReadKey();
            }
            else if (name == "gast")
            {
                ik.addFriend(gast);
                Console.WriteLine("Friend added.");
            }
            else if (name == "dude")
            {
                ik.addFriend(dude);
                Console.WriteLine("Friend added.");
            }
            else if (name == "buddy")
            {
                ik.addFriend(buddy);
                Console.WriteLine("Friend added.");
            }
            else if (name == "joch")
            {
                ik.addFriend(joch);
                Console.WriteLine("Friend added.");
            }
            else
            {
                Console.WriteLine("This person doesn't exist.");
            }
            Console.ReadKey();
            Friends();
        }

        static void RemoveFriend()
        {
            ik.printFriends();
            Console.WriteLine("\n Please enter the index number of the friend you want to remove:");
            int index = int.Parse(Console.ReadLine());
            Person removeFriend = ik.getFriend()[index - 1];
            ik.removeFriend(removeFriend);
            Friends();
        }

        static void ShowFriends()
        {
            ik.printFriends();
            Console.WriteLine("\n Press any key to go back");
            Console.ReadKey();
            Friends();
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
                    SelectPlaylist();
                    return;
                case "3":
                    AddPlaylist();
                    return;
                case "4":
                    RemovePlaylists();
                    return;
                case "5":
                    MainMenu();
                    return;
                default:
                    Playlists();
                    return;
            }
        }

        static void RemovePlaylists()
        {
            ik.printPlaylists();
            Console.WriteLine("\n Please enter the index number of the playlist you want to remove:");
            string name = Console.ReadLine();
            if (Int32.TryParse(name, out int i))
            {
                Playlist toRemove = ik.getPlaylists()[Int32.Parse(name) - 1];
                ik.removePlaylist(toRemove);
            }
            else
            {
                Console.WriteLine("This playlist doesn't exist.");
                Console.ReadKey();
            }
            Playlists();
        }

        static void RemovePlaylist(Playlist temp)
        {
            ik.removePlaylist(temp);
            Playlists();
        }

        static void AddPlaylist()
        {
            Console.WriteLine("What is the name of the playlist?");
            string input = Console.ReadLine();
            Playlist temp = new Playlist(0, input, false, ik);
            ik.addPlaylist(temp);
            Playlists();
        }

        static void SelectPlaylist()
        {
            
            Console.Clear();
            ik.printPlaylists();
            Console.WriteLine("Choose an playlist by typing its index number:");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int i))
            {
                Playlist temp = ik.getPlaylists()[Int32.Parse(input) - 1];
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Show the playlist");
                Console.WriteLine("2) Add song");
                Console.WriteLine("3) Add album");
                Console.WriteLine("4) Add playlist");
                Console.WriteLine("5) Remove song");
                Console.WriteLine("6) Remove Playlist");
                Console.WriteLine("7) Back");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ShowSongs(temp);
                        return;
                    case "2":
                        AddSong(temp);
                        return;
                    case "3":
                        AddAlbum(temp);
                        return;
                    case "4":
                        AddPlaylistToPlaylist(temp);
                        return;
                    case "5":
                        RemoveSong(temp);
                        return;
                    case "6":
                        RemovePlaylist(temp);
                        return;
                    case "7":
                        Playlists();
                        return;
                    default:
                        Playlists();
                        return;
                }
            }
            else
            {
                Console.WriteLine("This playlist doesn't exist.");
                Console.ReadKey();
                Playlists();
            }
        }

        static void AddPlaylistToPlaylist(Playbum temp)
        {
            Console.Clear();
            Console.WriteLine("Choose an playlist from wich you want to add all the songs:");
            ik.printFriendsPlaylists();
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int i))
            {
                Playlist addPlaylist = ik.getFriendsPlaylists()[Int32.Parse(input) - 1];
                temp.addPlaybum(addPlaylist);
                Playlists();
            }
            else
            {
                Console.WriteLine("This playlist doesn't exist.");
                Console.ReadKey();
                AddPlaylistToPlaylist(temp);
            }
        }


        static void AddAlbum(Playbum temp)
        {
            Console.Clear();
            Console.WriteLine("Choose an album from wich you want to add all the songs:");
            Console.WriteLine("1) Devided deluxe");
            Console.WriteLine("2) Equals");
            Console.WriteLine("3) Five");
            Console.WriteLine("4) Back");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    temp.addPlaybum(devidedDeluxe);
                    return;
                case "2":
                    temp.addPlaybum(equals);
                    return;
                case "3":
                    temp.addPlaybum(five);
                    return;
                case "4":
                    Playlists();
                    return;
                default:
                    AddAlbum(temp);
                    return;
            }
            Playlists();
        }


        static void AddSong(Playbum temp)
        {
            Console.Clear();
            Console.WriteLine("Choose an album from wich you want to add a song:");
            Console.WriteLine("1) Devided deluxe");
            Console.WriteLine("2) Equals");
            Console.WriteLine("3) Five");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    devidedDeluxe.getSongs();
                    switch (Console.ReadLine())
                    {
                        case "1":
                            temp.addSong(devidedDeluxe.getSong()[0]);
                            return;
                        case "2":
                            temp.addSong(devidedDeluxe.getSong()[1]);
                            return;
                        case "3":
                            temp.addSong(devidedDeluxe.getSong()[2]);
                            return;
                    }
                    return;
                case "2":
                    equals.getSongs();
                    switch (Console.ReadLine())
                    {
                        case "1":
                            temp.addSong(equals.getSong()[0]);
                            return;
                        case "2":
                            temp.addSong(equals.getSong()[1]);
                            return;
                    }
                    return;
                case "3":
                    five.getSongs();
                    switch (Console.ReadLine())
                    {
                        case "1":
                            temp.addSong(five.getSong()[0]);
                            return;
                        case "2":
                            temp.addSong(five.getSong()[1]);
                            return;
                    }
                    return;
                default:
                    AddSong(temp);
                    return;
            }
            Playlists();
        }

        static void RemoveSong(Playbum temp)
        {
            temp.getSongs();
            Console.WriteLine("\n Please enter the index number of the song you want to remove:");
            string name = Console.ReadLine();
            if (Int32.TryParse(name, out int i))
            {
                temp.removeSong(temp.getSong()[Int32.Parse(name) - 1]);
            }
            else
            {
                Console.WriteLine("This song doesn't exist.");
                Console.ReadKey();
            }
            Playlists();
        }

        static void ShowSongs(Playlist temp)
        {
            temp.printlist();
            Console.WriteLine("\n Press any key to go back");
            Console.ReadKey();
            Playlists();
        }

        static void ShowPlaylists()
        {
            Console.Clear();
            ik.printPlaylists();
            Console.WriteLine("\r\nPress any key to continue...");
            Console.ReadKey();
            Playlists();
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
                    PlayPlaylist();
                    return;
                case "3":
                    PlayAlbum();
                    return;
                case "4":
                    MainMenu();
                    return;
                default:
                    PlaySomething();
                    return;
            }
        }

        static void PlayPlaylist()
        {
            Console.Clear();
            ik.printPlaylists();
            Console.WriteLine("Select an playlist by typing its index number:");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int i))
            {
                Console.Clear();
                Playlist temp = ik.getPlaylists()[Int32.Parse(input) - 1];
                Console.WriteLine("1) Play " + temp.getName() + " normaly");
                Console.WriteLine("2) Play " + temp.getName() + " shuffled");
                Console.WriteLine("3) Back");
                Console.Write("\r\nSelect an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        current = temp;
                        current.play(false);
                        playing.Clear();
                        playing = temp.getSong();
                        return;
                    case "2":
                        current = temp;
                        current.play(true);
                        playing.Clear();
                        playing = temp.getSong();
                        return;
                    case "3":
                        PlaySomething();
                        return;
                    default:
                        PlayPlaylist();
                        return;
                }
            }
            else
            {
                Console.WriteLine("Error with given input. Press any key to continue...");
            }
            
            
            Console.ReadKey();
            PlaySomething();
        }


        static void PlaySong()
        {
            Console.Clear();
            Console.WriteLine("Choose an album from wich you want to play a song:");
            Console.WriteLine("1) Devided deluxe");
            Console.WriteLine("2) Equals");
            Console.WriteLine("3) Five");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Choose a song that you want to play: ");
                    devidedDeluxe.getSongs();
                    string inputSong = Console.ReadLine();
                    if (Int32.TryParse(inputSong, out int i))
                    {
                        Song playSong = devidedDeluxe.getSong()[Int32.Parse(inputSong) - 1];
                        current = playSong;
                        current.play(false);
                        playing.Clear();
                        playing.Add(playSong);
                    }
                    else
                    {
                        Console.WriteLine("Error with given input. Press any key to continue...");
                        Console.ReadKey();
                    }
                    return;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Choose a song that you want to play: ");
                    equals.getSongs();
                    string inputSong2 = Console.ReadLine();
                    if (Int32.TryParse(inputSong2, out int i2))
                    {
                        Song playSong2 = equals.getSong()[Int32.Parse(inputSong2) - 1];
                        current = playSong2;
                        current.play(false);
                        playing.Clear();
                        playing.Add(playSong2);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error with given input. Press any key to continue...");
                        Console.ReadKey();
                    }
                    return;
                case "3":
                    Console.WriteLine("Choose a song that you want to play: ");
                    five.getSongs();
                    string inputSong3 = Console.ReadLine();
                    if (Int32.TryParse(inputSong3, out int i3))
                    {
                        Song playSong3 = five.getSong()[Int32.Parse(inputSong3) - 1];
                        current = playSong3;
                        current.play(false);
                        playing.Clear();
                        playing.Add(playSong3);
                    }
                    else
                    {
                        Console.WriteLine("Error with given input. Press any key to continue...");
                        Console.ReadKey();
                    }
                    return;
                default:
                    PlaySong();
                    return;
            }
            Console.ReadKey();
            PlaySomething();
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
                default:
                    PlayAlbum();
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
                    current = album;
                    current.play(false);
                    playing.Clear();
                    playing = album.getSong();
                    return;
                case "2":
                    current = album;
                    current.play(true);
                    playing.Clear();
                    playing = album.getSong();
                    return;
                case "3":
                    PlayAlbum();
                    return;
                default:
                    PlayAlbum();
                    return;
            }
            Console.ReadKey();
            PlaySomething();

        }
    }
}