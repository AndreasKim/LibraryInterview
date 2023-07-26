using Lending.Books.Domain;
using Lending.Patrons.Domain;
using Xunit;
using FluentAssertions;
using FluentValidation;
using Lending.Patrons.Domain.Events;

namespace Lending.Books.UnitTests.Domain;

public class PatronRequestingCloseEndedHoldTest
{
    [Fact]
    public void OnePatronCanOnlyHold5BooksAtATime()
    {
    }
}
