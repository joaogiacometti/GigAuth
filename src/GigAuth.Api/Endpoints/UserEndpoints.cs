using GigAuth.Application.UseCases.Users.Create;
using GigAuth.Application.UseCases.Users.Delete;
using GigAuth.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace GigAuth.Api.Endpoints;

public static class UserEndpoints
{
    public static void AddUserEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/users")
            .WithName("Users")
            .WithTags("Users");

        group.MapPost("", async ([FromServices] ICreateUserUseCase useCase, [FromBody] RequestCreateUser request) =>
            {
                await useCase.Execute(request);

                return Results.Created();
            })
            .Produces(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

        // TODO: Implement auth
        group.MapDelete("{id:guid}", async ([FromServices] IDeleteUserUseCase useCase, [FromRoute] Guid id) =>
            {
                await useCase.Execute(id);

                return Results.NoContent();
            })
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound);
    }
}