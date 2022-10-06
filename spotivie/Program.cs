namespace spotivie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Genre genre = Genre.Other;
            Song song = new Song("Hello", new List<Artist>(), 0);
            switch(song.genre)
            {
                case Genre.Pop:
                    break;
                case Genre.HipHop:
                    break;
            }
        }
    }
}