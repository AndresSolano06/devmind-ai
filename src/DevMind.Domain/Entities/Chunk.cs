public class Chunk
{
    public Guid Id { get; private set; }
    public Guid DocumentId { get; private set; }
    public string Content { get; private set; } = string.Empty;
    public int Order { get; private set; }
    public float[]? Embedding { get; private set; }
    private Chunk() { }
    public Chunk(Guid documentId, string content, int order)
    {
        Id = Guid.NewGuid();
        DocumentId = documentId;
        Content = content;
        Order = order;
    }
    public void SetEmbedding(float[] embedding) => Embedding = embedding;
}