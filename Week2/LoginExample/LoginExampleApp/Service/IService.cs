namespace LoginExampleApp.Service;

public interface IService <T>
{
    // CRUD
    public T GetById(int Id);

    public ICollection<T> GetAll();

    public void Create(T item);

    public void Delete(T item);

    public void Update(T item);
}