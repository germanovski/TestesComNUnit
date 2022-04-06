using Moq;
using NUnit.Framework;


namespace ControleFuncionarios.Teste
{
    [TestFixture]
    public class FuncionariosManagerTestes
    {

        [Test]
        public void DeveAlterarONomeDoProfissional()
        {
            var XiforimpolasFuncionario = new Funcionario()
            {
                Nome = "Xiforimpolas NãoSeiDasQuantas",
                Salario = 1000,
                Sexo = "beautyfenty"
            };

            var FuncionarioManegerMock = new Mock<ControleFuncionarios.FuncionariosManager>();
            FuncionarioManegerMock.Setup(x => x.AlteraNomeDoFuncionario(It.IsAny<Funcionario>())).Returns(XiforimpolasFuncionario);

            var funManagerObj = FuncionarioManegerMock.Object;

            var funcionarioAlterado = funManagerObj.AlteraNomeDoFuncionario(null);
            Console.Out.WriteLine(funcionarioAlterado.Nome);

            Assert.AreSame(XiforimpolasFuncionario, funcionarioAlterado);
        }

        [Test]
        public void DeveCadastrarUmNovoProfissional()
        {
            var bdManagerMock = new Mock<ControleFuncionarios.BancoDeDadosManager>();
            bdManagerMock.Setup(x => x.InsereFuncionarioNoBancoDeDados(It.IsAny<Funcionario>())).Returns(true);

            var funManagerObj = new FuncionariosManager();
            var DeuCerto = funManagerObj.CadastrarFuncionario(
                "Riri de Melo e Silva", 4000, "Feminino", bdManagerMock.Object);


            Console.Out.WriteLine(DeuCerto.ToString());
        }


        [Test]
        public void NaoDeveCadatrarUsuarioPorNomeMuitoPequeno()
        {
            var bdManagerMock = new Mock<ControleFuncionarios.BancoDeDadosManager>();
            bdManagerMock.Setup(x => x.InsereFuncionarioNoBancoDeDados(It.IsAny<Funcionario>())).Returns(false);

            var funManagerObj = new FuncionariosManager();
            var ExceptionNome = Assert.Throws<Exception>(() => funManagerObj.CadastrarFuncionario("Ri", 4000, "Feminino", bdManagerMock.Object));
            Assert.That(ExceptionNome.Message == "Nome Inválido");

        }

        [Test]
        public void NaoDeveCadatrarUsuarioPorSalarioMuitoBaixo()
        {
            var bdManagerMock = new Mock<ControleFuncionarios.BancoDeDadosManager>();
            bdManagerMock.Setup(x => x.InsereFuncionarioNoBancoDeDados(It.IsAny<Funcionario>())).Returns(false);

            var funManagerObj = new FuncionariosManager();

            var ExceptionNome = Assert.Throws<Exception>(() => funManagerObj.CadastrarFuncionario("Riri de Melo", 400, "Feminino", bdManagerMock.Object));
            Assert.That(ExceptionNome.Message == "Salário Invalido");
        }
    }
}
