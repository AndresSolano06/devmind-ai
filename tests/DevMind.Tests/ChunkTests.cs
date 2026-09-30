using DevMind.Domain.Entities;
using Xunit;
public class ChunkTests
{
    [Fact]
    public void NewChunk_HasNoEmbeddingByDefault()
    {
        var chunk = new Chunk(Guid.NewGuid(), "Texto de ejemplo", 0);
        Assert.Null(chunk.Embedding);
    }
    [Fact]
    public void SetEmbedding_AssignsTheVector()
    {
        var chunk = new Chunk(Guid.NewGuid(), "Texto de ejemplo", 0);
        var vector = new float[] { 0.1f, 0.2f, 0.3f };
        chunk.SetEmbedding(vector); Assert.Equal(vector, chunk.Embedding);
    }
}