namespace SecretSanta.Web.ViewModels{
    public class GiftsViewModel{
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";     
        public string Url { get; set; } = "";
        public int Priority { get; set; } = 0;

        public object user { get; set; } = "";
    }
}