using System.Linq;

namespace YatingTtsClient.Constants
{
    public class InputType
    {
        public static string Text = "text";
        public static string Ssml = "ssml";

        public static bool Validation(string inputType)
        {
            string[] inputTypes = { Text, Ssml };
            return inputTypes.Contains(inputType);
        }
    }
}

