using Bogus;
using GigAuth.Domain.Filters;

namespace CommonTestsUtilities.Requests.Filters;

public static class RequestUserFilterBuilder
{
    public static RequestUserFilter Build()
    {
        return new Faker<RequestUserFilter>()
            .RuleFor(u => u.UserName, f => f.Internet.UserName().PadRight(8, 'a'))
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.IsActive, f => f.Random.Bool())
            .Generate();
    }
}