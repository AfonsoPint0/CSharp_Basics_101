using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            var account = new BankAccount("Kendra", 1000);

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWhitdrawal(8000, DateTime.Now, "Attempt to overdraw")
                );
        }

        [Fact]
        public void NeedMoneyToStart()
        {
            Assert.Throws<ArgumentOutOfRangeException>(

                () => new BankAccount("Invalid", -55)

                );
        }

    }
}