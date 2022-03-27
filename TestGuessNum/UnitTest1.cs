using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace TestGuessNum
{
    public class UnitTest1
    {
        private readonly Program _sut;
        public UnitTest1()
        {
            _sut = new Program();
        }

        [Fact]
        public void Hello()
        {
            // Arrange
            //object pgm = new Program();

            // Act
            //string[] prm = new string[] {"h"};
            //var result = _sut.p ToString();
            // Assert

           // Assert.Equal("Hello World!", result);
            
        }
    }
}
