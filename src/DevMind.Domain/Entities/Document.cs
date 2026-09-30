namespace DevMind.Domain.Entities;

public class Document
{
    public Guid Id { get; private set; }
    public string FileName { get; private set; }
    public string ContentType { get; private set; }
    public DateTime UploadedAt { get; private set; }
    public DocumentStatus Status { get; private set; }

    private Document() { }

    public Document(string fileName, string contentType)
    {
        Id = Guid.NewGuid();
        FileName = fileName;
        ContentType = contentType;
        UploadedAt = DateTime.UtcNow;
        Status = DocumentStatus.Pending;
    }

    public void MarkAsProcessed() => Status = DocumentStatus.Processed;
    public void MarkAsFailed() => Status = DocumentStatus.Failed;
}

public enum DocumentStatus { Pending, Processed, Failed }