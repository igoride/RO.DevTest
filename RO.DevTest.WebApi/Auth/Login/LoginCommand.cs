using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RO.DevTest.WebApi.Auth.Login;

public record LoginCommand(string Email, string Password) : IRequest<IActionResult>;