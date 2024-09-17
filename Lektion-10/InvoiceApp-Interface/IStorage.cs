namespace InvoiceApp;

public interface IStorage
{
  public void Read();
  public void Save();
  public void Update();
  public void Delete();
}
