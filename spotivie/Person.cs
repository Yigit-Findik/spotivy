using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{

    //NEED REVIEW UNSURE IF RIGHT

    internal class Person
    {
        public string Name;
        private List<Person> Friends;
        private List<Playlist> Playlists;

        public Person(string name, List<Person> friends, List<Playlist> playlists)
        {
            Name = name;
            Friends = friends;
            Playlists = playlists;
        }

        public List<Person> ShowFriends()
        {
            return Friends;
        }

        public List<Playlist> ShowPlaylists()
        {
            return Playlists;
        }

        //inherits playlist??? ask Robert for more info
        public Playlist SelectPlaylist(int choice)
        {
            return Playlists[choice];
        }

        public override string ToString()
        {
            List<string> friendNames = new List<string>();
            foreach (Person friend in Friends)
            {
                friendNames.Add(friend.Name);
            }
            string splitFriendsList = string.Join(", ", friendNames);
            return "User information\r\n" + "Name: " + Name + "\r\nFriends: " + splitFriendsList + "\r\nPlaylists: " + ShowPlaylists() + "\r\n";
        }

    }
}
