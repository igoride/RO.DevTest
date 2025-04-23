using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RO.DevTest.WebApi.Auth.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, IActionResult>
{
    public async Task<IActionResult> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        // Lógica de autenticação aqui
        if (request.Email == "admin@example.com" && request.Password == "123456")
        {
            return new OkObjectResult(new { Token = "fake-jwt-token" });
        }

        return new UnauthorizedResult();
    }
}