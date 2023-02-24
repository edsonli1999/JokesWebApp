namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswe { get; set; }

        // ctor -> shortcut to create constructor
        public Joke()
        {

        }
    }
}
