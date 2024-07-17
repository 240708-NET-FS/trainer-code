using LoginExampleApp.DAO;
using LoginExampleApp.Service;

namespace LoginExampleApp.Controller;

public class UserController
{

    private UserService userService;

    public UserController(UserService service)
    {
        userService = service;
    }


}