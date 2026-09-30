using DevMind.Domain.Entities;
using Xunit;
public class DocumentTests
{
    [Fact]
    public void NewDocument_StartsWithPendingStatus()
    {
        var document = new Document("manual.pdf", "application/pdf");
        Assert.Equal(DocumentStatus.Pending, document.Status);
    }
    [Fact]
    public void MarkAsProcessed_ChangesStatusToProcessed()
    {
        var document = new Document("manual.pdf", "application/pdf");
        document.MarkAsProcessed();
        Assert.Equal(DocumentStatus.Processed, document.Status);
    }
}