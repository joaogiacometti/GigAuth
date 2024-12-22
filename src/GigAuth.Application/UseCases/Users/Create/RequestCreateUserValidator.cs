using FluentValidation;
using GigAuth.Communication.Requests;
using GigAuth.Exception.Resources;

namespace GigAuth.Application.UseCases.Users.Create;

public class RequestCreateUserValidator: AbstractValidator<RequestCreateUser>
{
    public RequestCreateUserValidator()
    {
        RuleFor(u => u.UserName)
            .NotEmpty().WithMessage(ResourceErrorMessages.USER_NAME_EMPTY)
            .MinimumLength(8).WithMessage(ResourceErrorMessages.USER_NAME_TOO_SHORT)
            .MaximumLength(100).WithMessage(ResourceErrorMessages.USER_NAME_TOO_LONG);
        RuleFor(u => u.Email)
            .NotEmpty().WithMessage(ResourceErrorMessages.EMAIL_EMPTY)
            .EmailAddress().WithMessage(ResourceErrorMessages.EMAIL_INVALID)
            .MaximumLength(256).WithMessage(ResourceErrorMessages.EMAIL_TOO_LONG);
        RuleFor(u => u.Password)
            .SetValidator(new PasswordValidator<RequestCreateUser>());
    }
}