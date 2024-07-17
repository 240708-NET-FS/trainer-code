namespace LoginExampleApp.DAO;

public interface IDAO<T>
{
    // CRUD

    // Create
    public void Create(T item);

    // Read
    public T GetById(int ID);

    public ICollection<T> GetAll();

    // Update
    public void Update(T newItem);

    // Delete

    public void Delete(T item);
}