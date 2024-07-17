using System.Reflection.Metadata;
using LoginExampleApp.Entities;

namespace LoginExampleApp.DAO;

public class UserDAO : IDAO<User>
{
    private ApplicationDbContext _context;

    public UserDAO(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Create(User item)
    {
        _context.Users.Add(item);
        _context.SaveChanges();
    }

    public void Delete(User item)
    {
        _context.Users.Remove(item);
        _context.SaveChanges();
    }

    public ICollection<User> GetAll()
    {
        List<User> users = _context.Users.ToList();

        return users;
    }

    public User GetById(int ID)
    {
        User user = _context.Users.FirstOrDefault(u => u.UserID == ID);

        return user;
    }

    public void Update(User newItem)
    {
        User originalUser = _context.Users.FirstOrDefault(u => u.UserID == newItem.UserID);

        if (originalUser != null)
        {
            originalUser.FirstName = newItem.FirstName;
            originalUser.LastName = newItem.LastName;

            _context.Users.Update(originalUser);
            _context.SaveChanges();
        }

    }
}