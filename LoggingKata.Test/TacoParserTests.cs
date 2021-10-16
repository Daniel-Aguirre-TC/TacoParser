using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {

        // This test will ensure that the TacoParser.Parse() method is returning a non-null ITrackable object.
        [Fact]
        public void ShouldReturnNonNull()
        {           
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");
            
            // Assert
            Assert.NotNull(actual);
        }

        // This test will ensure that the proper Longitude was parsed.
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line).Location.Longitude;

            //Assert
            Assert.Equal(actual, expected);
        }


        // This test will ensure that the proper Latitude was parsed.
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line).Location.Latitude;

            //Assert
            Assert.Equal(actual, expected);
        }










        /*The purpose of this test is to make sure that your TacoParser.Parse() method is not returning null.

           The test has already been filled out for you. The three steps for creating a test are as follows:

           1) Arrange   <---   Create an instance of the class you are testing a method on.  

           2) Act       <---   Call the method that you're testing. Store the return in a var named "actual".     

           3) Assert    <---    Use the Assert class to call a method that will verify the conditions of the test.

                 Review this test, and then create two additional tests that will return the requested data. */


    }
}
