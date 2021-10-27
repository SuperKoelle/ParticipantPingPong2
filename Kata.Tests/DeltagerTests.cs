using FluentAssertions;
using System;
using Xunit;

namespace Kata.Tests
{
    public class ParticipantsTests
    {
        [Fact]
        [Trait ("Catagory", "City")]
        public void ParticipantsCityValid()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "Vejle";

            // Act
            sut.City = positiveResult;

            // Assert
            sut.City.Should().Be(positiveResult);
        }

        [Fact]
        [Trait("Catagory", "City")]
        public void ParticipantsCitySymbols()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "#¤%";

            // Act
           // sut.City = positiveResult;

            // Assert
            Assert.Throws<ArgumentException>(() => sut.City = positiveResult);
        }
        //::::::::::::::::::::::::::::
        [Fact]
        [Trait("Catagory", "Name")]
        public void ParticipantsNameMustBeNull()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "Michael";

            // Act
            sut.Name = positiveResult;

            // Assert
            sut.Name.Should().Be(positiveResult);
        }

        [Fact]
        [Trait("Catagory", "Name")]
        public void ParticipantsNameMustNotBeNull()
        {
            // Arrange
            var sut = new Participant();

           
           
            string nullName = null;
            // Act
             
            // Assert
          
            Assert.Throws<ArgumentException>(() => sut.Name = nullName);

        }

        //::::::::::::::::::::::::::::
        [Fact]
        [Trait("Catagory", "Name")]
        public void ParticipantsNameMustBeNullEmpty()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "Michael";

            // Act
            sut.Name = positiveResult;

            // Assert
            sut.Name.Should().Be(positiveResult);
        }

        [Fact]
        [Trait("Catagory", "Name")]
        public void ParticipantsNameMustNotBeNullEmpty()
        {
            // Arrange
            var sut = new Participant();

            var emptyName = "";
           
            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => sut.Name = emptyName);
        }

        //::::::::::::::::::::::::::::

        [Theory]
        [InlineData("Marie")]
        [InlineData("Anne Marie")]
        [InlineData("Anne-Marie")]
        [Trait("Catagory", "Name")]
        public void ParticipantsNameValid(string name)
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = name;

            // Act
            sut.Name = positiveResult;

            // Assert
            sut.Name.Should().Be(positiveResult);
        }

        [Theory]
        [InlineData("#¤%")]
        [InlineData("9")]
        [Trait("Catagory", "Name")]
        public void ParticipantsNameNonValidWithSymbols(string testData)
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = testData;

            // Act
            // sut.City = positiveResult;

            // Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);

        }

        [Theory]
        [InlineData("john","John")]
        [InlineData("joHn","John")]
        [InlineData("JOHN", "John")]
        [InlineData("joHn-kølle", "John-Kølle")]
        [InlineData("joHn kølle", "John Kølle")]
        [InlineData("joHn kØlle", "John Kølle")]
        [InlineData("joHn-kØlle Chernyayev List", "John-Kølle Chernyayev List")]
        [Trait("Catagory", "Name")]
        public void ParticipantsNameGetCapitalFirstLetterAndTheRestSmallRegardlessOfFormatting(string name, string expected)
        {
            // Arrange
            var sut = new Participant();

            sut.Name = name;
            
            // Assert
            sut.Name.Should().Be(expected);
        }
    }
}