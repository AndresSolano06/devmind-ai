namespace DevMind.Domain.Entities;
public class Answer
{
    public Guid Id { get; private set; }
    public Guid QuestionId { get; private set; }
    public string Text { get; private set; } = string.Empty;
    public IReadOnlyList<Guid> SourceChunkIds { get; private set; } = new List<Guid>();
    private Answer() { }
    public Answer(Guid questionId, string text, IReadOnlyList<Guid> sourceChunkIds)
    {
        Id = Guid.NewGuid();
        QuestionId = questionId;
        Text = text;
        SourceChunkIds = sourceChunkIds;
    }
}