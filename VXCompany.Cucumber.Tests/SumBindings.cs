using FluentAssertions;
using TechTalk.SpecFlow;

namespace Cucumber.Demo
{
    [Binding]
    public class SumBinding
    {
        private NumberCollection _numbers;
        private int _result;

        [Given("the number (.*)")]
        public void Given(int number)
        {
            _numbers = new NumberCollection(number);
        }

        [Given("we add (.*)")]
        public void WeAdd(int number)
        {
            _numbers.Add(number);
        }

        [When("calculating")]
        public void Calculating()
        {
            _result = _numbers.Sum();
        }

        [Then("the result should be (.*)")]
        public void ResultShouldBe(int number)
        {
            _result.Should().Be(number);
        }
    }
}
