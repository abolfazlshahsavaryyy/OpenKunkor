
namespace OpenKunkor.Domain.Arguments
{
    public class CustomArgumentException
    {
        public static void ThrowIfNotInRange(string content,int beginSize,int terminalSize)
        {
            if(content.Length<beginSize || content.Length > terminalSize)
            {
                throw new Exception($"out of the range.\ncontent: {content} " +
                    $"\nbeginSize :{beginSize}" +
                    $"\ncontentSize: {content.Length}" +
                    $"\nterminalSize:{terminalSize}");
            }
        }
    }
}
