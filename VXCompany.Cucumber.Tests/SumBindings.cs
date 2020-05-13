using FluentAssertions;
using TechTalk.SpecFlow;

namespace VXCompany.Cucumber.Tests
{
    [Binding]
    public class SumBindings
    {
        private Number _number;
        private int _actualValue;

        [Given("^the number (\\d+)$")]
        public void TheNumber(int number)
        {
            _number = new Number(number);
        }

        [Given("^we add (\\d+)$")]
        public void WeAdd(int number)
        {
            _number.Add(number);
        }

        [When("^calculating$")]
        public void Calculating()
        {
            _actualValue = _number.GetValue();
        }

        [Then("^the result should be (\\d+)$")]
        public void TheResultShouldBe(int expectedValue) 
        {
            _actualValue.Should().Be(expectedValue);
        }
    }
}
