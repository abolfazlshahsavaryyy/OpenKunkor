using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.QuizReview
{
    public class QuizReviewId
    {
        public Guid Value { get; set; }
        public static QuizReviewId Of(Guid Id)
        {
            CustomArgumentException.ThrowIfIdIsNull(Id);
            return new QuizReviewId
            {
                Value = Id
            };
        }
    }
}
