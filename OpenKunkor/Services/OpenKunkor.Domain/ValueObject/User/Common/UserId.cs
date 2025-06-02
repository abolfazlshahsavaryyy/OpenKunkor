using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.User.Common
{
    class UserId
    {
        public Guid Value { get; set; }
        public static UserId Of(Guid Id)
        {
            CustomArgumentException.ThrowIfIdIsNull(Id);
            return new UserId
            {
                Value = Id
            };
        }
    }
}
