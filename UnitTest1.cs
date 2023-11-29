using Microsoft.AspNetCore.Http.HttpResults;
using WebAPIEcommerceCoreMVC.Model;
using WebAPIEcommerceCoreMVC.Service;

namespace WebApiMVCCoreTest
{
    public class UnitTest1
    {
        
            [Fact]
            public async Task consultaEmpresa()
            {
                //Arrange
                long id = 1;
                var emp = new Empresa();
                var service = new EmpresaService();

                //Act
                emp = await service.empresa(2);

                //Assert 
                // Assert.Equal(id, emp.id);
                Assert.False(id == emp.id);
            }
            [Fact]
            public async Task ListaEmpresas()
            {
                //Arrange
                long id = 1;

                var service = new EmpresaService();
                var empresas = new List<Empresa>();
                //Act
                empresas = await service.empresas();

                //Assert 

                Assert.True(empresas.Count() > 0);
            }
        [Fact]
        public async Task Atualizar()
        {
            //arrange
            Empresa emp = new Empresa();
            List<Empresa> empresas = new List<Empresa>();
            emp.id = 1;
            emp.nome_fantasia = "pet Love";
            emp.data_cadastro = "01/01/2023";
            EmpresaService service = new EmpresaService();
            //Act
            bool registrou = await service.AddOrUpdate(emp);

            //Assert
            Assert.True(registrou);
        }
            [Fact]
            public async void Add2()
            {
                //arrange
                Empresa emp = new Empresa();
                List<Empresa> empresas = new List<Empresa>();
                emp.id = 0;
                emp.nome_fantasia = "testeUnitario";
                emp.data_cadastro = "01/01/2023";
                EmpresaService service = new EmpresaService();
                //Act
                bool registrou = await service.AddOrUpdate(emp);

            //Assert
            Assert.True(registrou);
            }
        [Fact]
        public async void RemoverNome()
        {
            string codigo = "testeUnitario";
            EmpresaService service = new EmpresaService();
            bool removeu = await service.RemoveNome(codigo);
            Assert.True(removeu);
        }
    }
}