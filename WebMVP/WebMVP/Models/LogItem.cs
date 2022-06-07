namespace WebMVP.Models
{
    public class LogItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Format { get; set; }   
        public bool IsComplete { get; set; }
    }
}
