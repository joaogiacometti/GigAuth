using GigAuth.Communication.Responses;
using GigAuth.Domain.Filters;

namespace GigAuth.Application.UseCases.Users.GetFiltered;

public interface IGetFilteredUsersUseCase
{
    Task<List<ResponseUser>?> Execute(RequestUserFilter filter);
}