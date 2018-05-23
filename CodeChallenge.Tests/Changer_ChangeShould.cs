using System.Collections.Generic;
using Xunit;

namespace CodeChallenge.Tests
{
    public class Changer_ChangeShould
    {
        private readonly Changer _changer;
        public Changer_ChangeShould()
        {
            _changer = new Changer();
        }

        [Fact]
        public void ReturnNull_WithPaidLessThanPrice()
        {
            var price = 120D;
            var paid = 100D;

            var result = _changer.Change(price, paid);

            Assert.Null(result);
        }

        [Fact]
        public void ReturnNull_WithPaidEqualPrice()
        {
            var price = 100D;
            var paid = 100D;

            var result = _changer.Change(price, paid);

            Assert.Null(result);
        }

        [Fact]
        public void ReturnCorrect_1()
        {
            var price = 85D;
            var paid = 100D;

            var result = _changer.Change(price, paid);

            Assert.Equal(new Dictionary<double, int>
            {
                {10D,1 },
                {5D,1 }
            }, result);
        }

        [Fact]
        public void ReturnCorrect_2()
        {
            var price = 85.75;
            var paid = 1000D;

            var result = _changer.Change(price, paid);

            Assert.Equal(new Dictionary<double, int>
            {
                {500D, 1},
                {100D, 4},
                {10D, 1},
                {2D, 2},
                {0.25, 1}
            }, result);
        }

    }
}
