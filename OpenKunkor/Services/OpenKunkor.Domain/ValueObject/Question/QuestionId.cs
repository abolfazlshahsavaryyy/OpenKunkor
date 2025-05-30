
using System.Runtime.CompilerServices;

namespace OpenKunkor.Domain.ValueObject.Question
{
    public class QuestionId
    {
        public Guid Value { get; set; }
        public static QuestionId Of(Guid Id)
        {
            if(Id == null || Id==Guid.Empty)
            {
                throw new Exception("Id can't be null or enmpty");
            }
            return new QuestionId
            {
                Value = Id
            };
        }
    }
}
