using CommonTestsUtilities.Entities;
using CommonTestsUtilities.Repositories;
using CommonTestsUtilities.Repositories.Users;
using CommonTestsUtilities.Requests.Users;
using CommonTestsUtilities.Security;
using FluentAssertions;
using GigAuth.Application.UseCases.Users.Create;
using GigAuth.Domain.Entities;
using GigAuth.Exception.ExceptionBase;
using GigAuth.Exception.Resources;

namespace UseCase.Tests.Users;

public class CreateUserUseCaseTest
{
    [Fact]
    public async Task Success()
    {
        var request = RequestCreateUserBuilder.Build();
        var useCase = CreateUseCase();

        var act = async () => await useCase.Execute(request);

        await act.Should().NotThrowAsync();
    }

    [Fact]
    public async Task Error_UserName_Already_Used()
    {
        var user = UserBuilder.Build();

        var request = RequestCreateUserBuilder.Build();
        request.UserName = user.UserName;

        var useCase = CreateUseCase(userWithUserName: user);

        var act = async () => await useCase.Execute(request);

        var result = await act.Should().ThrowAsync<ErrorOnValidationException>();

        result.Where(ex =>
            ex.GetErrorList().Count == 1 && ex.GetErrorList().Contains(ResourceErrorMessages.USER_NAME_ALREADY_USED));
    }

    [Fact]
    public async Task Error_Email_Already_Used()
    {
        var user = UserBuilder.Build();

        var request = RequestCreateUserBuilder.Build();
        request.Email = user.Email;

        var useCase = CreateUseCase(userWithEmail: user);

        var act = async () => await useCase.Execute(request);

        var result = await act.Should().ThrowAsync<ErrorOnValidationException>();

        result.Where(ex =>
            ex.GetErrorList().Count == 1 && ex.GetErrorList().Contains(ResourceErrorMessages.EMAIL_INVALID));
    }

    [Fact]
    public async Task Error_Validation()
    {
        var request = RequestCreateUserBuilder.Build();
        request.UserName = "invalid";

        var useCase = CreateUseCase();

        var act = async () => await useCase.Execute(request);

        var result = await act.Should().ThrowAsync<ErrorOnValidationException>();

        result.Where(ex =>
            ex.GetErrorList().Count == 1 && ex.GetErrorList().Contains(ResourceErrorMessages.USER_NAME_TOO_SHORT));
    }

    private static CreateUserUseCase CreateUseCase(User? userWithUserName = null, User? userWithEmail = null)
    {
        var readRepository = new UserReadOnlyRepositoryBuilder()
            .GetByUserName(userWithUserName)
            .GetByEmail(userWithEmail)
            .Build();
        var writeRepository = new UserWriteOnlyRepositoryBuilder().Build();
        var unitOfWork = new UnitOfWorkBuilder().Build();
        var cryptography = new CryptographyBuilder().Build();

        return new CreateUserUseCase(writeRepository, readRepository, unitOfWork, cryptography);
    }
}