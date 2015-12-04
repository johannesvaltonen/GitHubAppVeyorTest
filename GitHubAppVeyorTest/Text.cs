using AutoMapper;

namespace GitHubAppVeyorTest
{
    public class Text
    {
        public static string ToUpper(string text)
        {
            return text.ToUpper();
        }

        public static string ToLower(string text)
        {
            return text.ToLower();
        }

        public static string Normalize(string text)
        {
            return text.Normalize();
        }

        public static string Trim(string text)
        {
            Mapper.AssertConfigurationIsValid();
            return text.Trim();
        }
    }
}