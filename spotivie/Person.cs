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
        protected List<Person> Friends; //super user is child of person so it can access this
        protected List<Playlist> Playlists; //protected so super user can use it aswell
        public Person(string name)
        {
            Name = name;
            Friends = new List<Person>();
            Playlists = new List<Playlist>();
        }
        public Person(string name, List<Person> friends, List<Playlist> playlists)
        {
            Name = name;
            Friends = friends;
            Playlists = playlists;
        }

        public List<Person> ShowFriends()
        {
            foreach (Person person in Friends)
            {
                Console.WriteLine(person.Name);
            }
            return Friends;
        }

        public List<Playlist> ShowPlaylists()
        {
            //not finished
            foreach (Playlist playlist in Playlists)
            {
                Console.WriteLine(playlist.Title);
            }
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
