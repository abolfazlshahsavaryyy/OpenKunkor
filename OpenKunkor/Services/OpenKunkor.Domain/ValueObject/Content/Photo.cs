using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.Content;

public class ContentPhoto
{
    public string PhotoUrl { get; set; } = string.Empty;
    public int PhotoSize { get; set; }
    public static ContentPhoto Of(string photoUrl,int photoSize)
    {
        ArgumentException.ThrowIfNullOrEmpty(photoUrl);
        CustomArgumentException.ThrowIfNotInRange(photoUrl, 10, 60);
        return new Photo
        {
            PhotoSize = photoSize,
            PhotoUrl=photoUrl
        };

    }

}
