namespace DevMind.Domain.Entities;
public class Question
{
    public Guid Id { get; private set; }
    public string Text { get; private set; } = string.Empty;
    public DateTime AskedAt { get; private set; }
    private Question() { }
    public Question(string text)
    {
        Id = Guid.NewGuid();
        Text = text; AskedAt = DateTime.UtcNow;
    }
}