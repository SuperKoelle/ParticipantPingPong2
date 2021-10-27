using FluentAssertions;
using System;
using Xunit;

namespace Kata.Tests
{
    public class ParticipantsTests
    {
        [Fact]
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

        [Fact]
        public void ParticipantsNameMustNotBeNull()
        {
            // Arrange
            var sut = new Participant();

           
           
            string nullName = null;
            // Act
             
            // Assert
          
            Assert.Throws<ArgumentException>(() => sut.Name = nullName);

        }


        [Fact]
        public void ParticipantsNameMustNotBeNullEmpty()
        {
            // Arrange
            var sut = new Participant();


            var emptyName = "";
           
            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => sut.Name = emptyName);
          

        }
    }
}