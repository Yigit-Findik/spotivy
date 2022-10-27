using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    internal class SuperUser : Person
    {
        public SuperUser(string name, List<Person> friends, List<Playlist> playlists) : base(name, friends, playlists)
        {
            Name = name;
            Friends = friends;
            Playlists = playlists;
        }

        public void AddFriend(Person friend)
        {
            Friends.Add(friend);
        }
        public void RemoveFriend(Person friend)
        {
            Friends.Remove(friend);
        }
        public Playlist CreatePlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
            return playlist;   
        }
        public void DeletePlaylist(int playlist)
        {
            //empty for now
        }
        public void AddToPlaylist(Playlist playlist, iPlayable playable)
        {
            playlist.Add(playable);
        }
        public void RemoveFromPlaylist(Playlist playlist, iPlayable playable)
        {
            playlist.Remove(playable);
        }

    }
}
