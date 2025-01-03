using CommonTestsUtilities.InlineData;
using CommonTestsUtilities.Requests.Users;
using FluentAssertions;
using FluentValidation;
using GigAuth.Application.UseCases.Users;
using GigAuth.Communication.Requests;

namespace Validator.Tests.Common;

public class PasswordValidatorTest
{
    [Theory]
    [ClassData(typeof(PasswordInlineDataTest))]
    public void Error_Password_Invalid_Create(string password)
    {
        var request = RequestCreateUserBuilder.Build();
        request.Password = password;

        var validator = new PasswordValidator<RequestCreateUser>();

        var result = validator
            .IsValid(new ValidationContext<RequestCreateUser>(request), password);

        result.Should().BeFalse();
    }
    
    [Theory]
    [ClassData(typeof(PasswordInlineDataTest))]
    public void Error_Password_Invalid_Login(string password)
    {
        var request = RequestLoginBuilder.Build();
        request.Password = password;

        var validator = new PasswordValidator<RequestLogin>();

        var result = validator
            .IsValid(new ValidationContext<RequestLogin>(request), password);

        result.Should().BeFalse();
    }
    
    [Theory]
    [ClassData(typeof(PasswordInlineDataTest))]
    public void Error_Password_Invalid_Change_Password(string newPassword)
    {
        var request = RequestChangePasswordBuilder.Build();
        request.NewPassword= newPassword;

        var validator = new PasswordValidator<RequestChangePassword>();

        var result = validator
            .IsValid(new ValidationContext<RequestChangePassword>(request), newPassword);

        result.Should().BeFalse();
    }
}