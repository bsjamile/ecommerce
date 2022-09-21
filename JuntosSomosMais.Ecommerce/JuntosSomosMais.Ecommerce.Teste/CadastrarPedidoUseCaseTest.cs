using JuntosSomosMais.Ecommerce.Application.UseCases.PedidoUseCase;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Teste
{
    [TestClass]
    public class CadastrarPedidoUseCaseTest
    {
        [TestMethod]
        public void ExecuteAsync_SeARequestForNula_RetornarBadRequestResult()
        {
            //Arrange
            Mock<IPedidoRepository> pedidoRepository = new Mock<IPedidoRepository>();
            pedidoRepository.Setup(s => s.Cadastrar(It.IsAny<Pedido>()))
                .Returns(Task.CompletedTask);

            var useCase = new CadastrarPedidoUseCase(pedidoRepository.Object);

            //Act
            var response = useCase.ExecuteAsync(null).Result;

            //Assert
            Assert.IsTrue(response.GetType() == typeof(BadRequestResult));


        }
        /*
        [TestMethod]
        public void ExecuteAsync_SePedidoTiverProdutoComQuantidadeZero_RetornarBadRequestResult()
        {
            //Arrange
            Mock<IPedidoRepository> pedidoRepository = new Mock<IPedidoRepository>();
            pedidoRepository.Setup(s => s.Cadastrar(It.IsAny<Pedido>()))
                .Returns(Task.CompletedTask);

            var useCase = new CadastrarPedidoUseCase(pedidoRepository.Object);

            //Act
            var response = useCase.ExecuteAsync(null).Result;

            //Assert
            Assert.IsTrue(response.GetType() == typeof(BadRequestResult));


        }*/
    }
}
