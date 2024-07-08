using Kinde.Api.Models.Configuration;

namespace BlazorApp1.Controller;

public class UserController 
{
    //todo: user login logic
    //KINDE AUTH
    /*
       private readonly IAuthorizationConfigurationProvider _authConfigurationProvider;
       private readonly IApplicationConfigurationProvider _appConfigurationProvider;
     */
    private readonly IAuthorizationConfigurationProvider _authorizationConfiguration;
    private readonly IApplicationConfigurationProvider _applicationConfiguration; 
    public UserController(IAuthorizationConfigurationProvider authorizationConfigurationProvider, IApplicationConfigurationProvider applicationConfiguration)
    {
        _authorizationConfiguration = authorizationConfigurationProvider;
        _applicationConfiguration = applicationConfiguration; 
    }

   /* public async Task<IActionResult> login()
    {
        
    }*/
}