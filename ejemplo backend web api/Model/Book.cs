namespace ejercicio_LU.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
//        public DateTime ReleaseDate { get; set; }

        public Editorial Editorial { get; set; }
    }
}