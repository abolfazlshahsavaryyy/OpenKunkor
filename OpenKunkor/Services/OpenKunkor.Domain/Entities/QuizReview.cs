using OpenKunkor.Domain.Abstraction;
using OpenKunkor.Domain.ValueObject.QuizReview;

public class QuizReview : Entity<QuizReviewId>
{
    public Rate Rate { get; set; }
    public ReviewDescription Description { get; set; }
    public QuizRate QuizRate { get; set; }
    public ReviewDate ReviewDate { get; set; }
    public StudentUserName StudentUserName { get; set; }

    public static QuizReview Create(
        QuizReviewId QuizReviewId,
        Rate rate,
        ReviewDescription description,
        QuizRate quizRate,
        ReviewDate reviewDate,
        StudentUserName studentUserName)
    {
        return new QuizReview
        {
            Id=QuizReviewId,
            Rate = rate,
            Description = description,
            QuizRate = quizRate,
            ReviewDate = reviewDate,
            StudentUserName = studentUserName
        };
    }
}
