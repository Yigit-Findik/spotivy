using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    internal class Client
    {
        public iPlayable CurrentlyPlaying;
        public int CurrentTime;
        public bool Playing;
        public bool Shuffle;
        public bool Repeat;
        private SuperUser ActiveUser;
        private List<Album> AllAlbums;
        private List<Song> AllSongs;
        private List<Person> AllUsers;

        public Client(List<Person> user, List<Album> albums, List<Song> songs)
        {
            AllUsers = user;
            AllAlbums = albums;
            AllSongs = songs;
        }

        public void SetActiveUser(Person user)
        {
            ActiveUser = new SuperUser(user);            
        }

        public void ShowActiveUser()
        {
            Console.WriteLine(ActiveUser.Name);
        }
        
        public void ShowAllAlbums()
        {
            //empty for now
        }
        public void SelectAlbum(int albumID)
        {
            //empty for now
        }
        public void ShowAllSongs()
        {
            //empty for now
        }
        public void SelectSong(int songID)
        {
            //empty for now
        }
        public void selectUser(int userID)
        {
            //empty for now
        }
        public void ShowUserPlaylists()
        {
            //empty for now
        }
        public void SelectUserPlaylist(int playlistID)
        {
            //empty for now
        }
        public void Play()
        {
            //empty for now
        }
        public void Pause()
        {
            //empty for now
        }
        public void Stop()
        {
            //empty for now
        }
        public void NextSong()
        {
            //empty for now
        }
        public void SetShuffle(bool shuffle)
        {
            //empty for now
        }
        public void SetRepeat(bool repeat)
        {
            //empty for now
        }
        public void CreatePlaylist(string title)
        {
            //empty for now
        }
        public void ShowPlaylists()
        {
            //empty for now
        }
        public void SelectPlaylist(int playlistID)
        {
            //empty for now
        }
        public void RemovePlaylist(int playlistID)
        {
            //empty for now
        }
        public void AddToPlaylist(int Add)
        {
            //empty for now
        }
        public void ShowSongsInPlaylist()
        {
            //empty for now
        }
        public void RemoveFromPlaylist(int Remove)
        {
            //empty for now
        }
        public void ShowFriends()
        {
            
        }
        public void SelectFriend()
        {
            //empty for now
        }
        public void AddFriend(int friendName)
        {

            ActiveUser.AddFriend(AllUsers[friendName]);

            //foreach (Person person in AllUsers)
            //{
            //    if (person.Name == friendName)
            //    {
            //        ActiveUser.AddFriend(person);
            //    }
            //}
        }
        public void RemoveFriend(int friendID)
        {
            //empty for now
        }


    }
}
