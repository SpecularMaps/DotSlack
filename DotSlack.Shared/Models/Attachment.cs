using System.Text;

// ReSharper disable once CheckNamespace
namespace DotSlack.Models
{
    public class Attachment
    {
        public string Fallback { get; set; }
        public int Colour { get; set; }
        public string PreText { get; set; }
        public string AuthorName { get; set; }
        public string AuthorLink { get; set; }
        public string AuthorIcon { get; set; }
        public string Title { get; set; }
        public string TitleLink { get; set; }
        public string Text { get; set; }

        public string ToJsonString()
        {
            var builder = new StringBuilder("{");

            builder.Append($"\"fallback\":\"{Fallback}\"");
            builder.Append($"\"color\":\"#{Colour:X6}\"");

            builder.Append("}");
            return builder.ToString();
        }
    }
}
