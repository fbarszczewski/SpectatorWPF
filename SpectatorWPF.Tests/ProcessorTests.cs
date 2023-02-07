using SpectatorWPF.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorWPF.Tests
{
    public class ProcessorTests
    {
        
        Processor processor = new Processor();

        [Fact]
        public void Name_ShouldReturnSameValue()
        {
            //Arrange
            string expected = Wmi.GetValue("root\\CIMV2", "Win32_Processor", "Name");


            //Act
            string actual = processor.Name;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Architecture_ShouldReturnSameValue()
        {
            //Arrange
            string expected = Wmi.GetValue("root\\CIMV2", "Win32_Processor", "AddressWidth");


            //Act
            string actual = processor.Architecture;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumberOfCores_ShouldReturnSameValue()
        {
            //Arrange
            string expected = Wmi.GetValue("root\\CIMV2", "Win32_Processor", "NumberOfCores");


            //Act
            string actual = processor.NumberOfCores;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CurrentClockSpeed_ShouldReturnSameValue()
        {
            //Arrange
            string expected = Wmi.GetValue("root\\CIMV2", "Win32_Processor", "CurrentClockSpeed");


            //Act
            string actual = processor.CurrentClockSpeed;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void L2CacheSize_ShouldReturnSameValue()
        {
            //Arrange
            string expected = Wmi.GetValue("root\\CIMV2", "Win32_Processor", "L2CacheSize");


            //Act
            string actual = processor.L2CacheSize;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void L3CacheSize_ShouldReturnSameValue()
        {
            //Arrange
            string expected = Wmi.GetValue("root\\CIMV2", "Win32_Processor", "L3CacheSize");


            //Act
            string actual = processor.L3CacheSize;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
