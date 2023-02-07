using SpectatorWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorWPF.Tests
{
    public class WmiTests
    {
        [Fact]
        public void GetValue_WrongNamespaceShouldReturnError()
        {
            //Arrange
            string expected = "Invalid namespace ";

            //Act
            string actual = Wmi.GetValue("Invalid", "Win32_Processor", "Name");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetValue_WrongClassShouldReturnError()
        {
            //Arrange
            string expected = "Invalid class ";

            //Act
            string actual = Wmi.GetValue("root\\CIMV2", "Invalid", "Name");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetValue_WrongPropertyShouldReturnError()
        {
            //Arrange
            string expected = "Invalid query ";

            //Act
            string actual = Wmi.GetValue("root\\CIMV2", "Win32_Processor", "Invalid");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetValues_WrongNamespaceShouldReturnError()
        {
            //Arrange
            List<string> expected = new List<string>() { "Invalid namespace " };

            //Act
            List<string> actual = Wmi.GetValues("Invalid", "Win32_Processor", new string[] { "Caption", "Names", "NumberOfCores" });

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetValues_WrongClassShouldReturnError()
        {
            //Arrange
            List<string> expected = new List<string>() { "Invalid class " };

            //Act
            List<string> actual = Wmi.GetValues("root\\CIMV2", "Invalid", new string[] { "Caption", "Names", "NumberOfCores" });

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void GetValues_WrongPropertyShouldReturnError()
        {
            //Arrange
            List<string> expected = new List<string>() { Wmi.GetValue("root\\CIMV2", "Win32_Processor", "Caption"), "Invalid query ", Wmi.GetValue("root\\CIMV2", "Win32_Processor", "NumberOfCores") };

            //Act
            List<string> actual = Wmi.GetValues("root\\CIMV2", "Win32_Processor", new string[] { "Caption", "Names", "NumberOfCores" });

            //Assert
            Assert.Equal(expected, actual);
        }
    }


}
