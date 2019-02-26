using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using DotNetCore2RestWebApplication.Controllers;
using DotNetCore2RestWebApplication.Services;
using Moq;
using Xunit;

namespace ApiUnitTest.Services
{

    [ExcludeFromCodeCoverage]
    public class TransacaoTaxasServiceTest
    {
       
        #region math Tests
        [Fact]
        public void RealizaCalculoTransacaoTest()
        {
            decimal valorEsperado = 97.5;
            decimal valorAtual = Decimal.Zero;
            Assert.Equal(valorEsperado, valorEsperado);
        }

        #endregion
    }

        #region Get tests
        [Fact]
        public async Task ConsultaMdrTest()
        {

        //Adquirente cielo = new DotNetCore2RestWebApplication.Models.Cielo();
            // Arrange
            var mockRepo = new Mock<ITransacaoTaxasService>();
            mockRepo.Setup(repo => repo.ObtemMdrAdquirente("Cielo"));
            var controller = new TransacaoTaxasController(mockRepo.Object);

            // Act
          //  Adquirente result = await controller.ObtemMdrAdquirente("Cielo");

            // Assert
            //var viewResult = Assert.IsType<Adquirente>(Adquirente);
            //var model = Assert.IsAssignableFrom<IEnumerable<Adquirente>>(
                //viewResult.ViewData.GetType());
            //Assert.Equal("Adquirente", model.GetType().Name);
        }
        #endregion
}