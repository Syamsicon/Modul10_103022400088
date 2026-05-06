namespace Modul10_103022400088
{
    public class Game
    {
        public string id {  get; set; }
        public string nama { get; set; }
        public string developer { get; set; }
        public string TahunRilis { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string[] platform { get; set; }
        public string[] Mode { get; set; }
        public bool isOnline { get; set; }
        public int Harga { get; set; }

        public Game() { }
    }
}
