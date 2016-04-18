using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;
using DesignPattern.Strategy;
using StringTools;
using Domain;


namespace TestsCase
{
    [TestFixture]
    public abstract class Test
    {
      
        public  List<Driver> drivers=new List<Driver>();
    //    public Driver a = new Driver(1,true,22);
      //  public Driver b = new Driver(2,false,25);

    }

    [TestFixture]
    public class TesteMulte : Test
    {
        [Test]
        public void AfisareTest1()
        {
          //  drivers.Add(a);
           // drivers.Add(b);
            var functie = StringHelpers.Concat(drivers, " ");
            Assert.AreEqual(functie, "George Alin");

        }

        [Test]
        public void CautaCuvant_Test()
        {
            // Arrange
            var searchStrategyMock = new Mock<ISearchStrategy>();
            var searchList = new SearchList();
            searchList.SetSearchStrategy(searchStrategyMock.Object);

            // Act
            searchList.CautaCuvant();

            // Assert
            searchStrategyMock.Verify(x => x.Search(It.IsAny<List<string>>(), It.IsAny<string>()), Times.Never);
        }
    }

 
}
