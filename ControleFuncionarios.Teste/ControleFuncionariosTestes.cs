using ControleFuncionarios;
using NUnit.Framework;

namespace ControleFuncionarios.Teste
{
    [TestFixture]
    public class ControleFuncionariosTestes
    {
        

        [Test]
        public static void VerificarInformacoesDoFuncionario()
        {
            List<Funcionario> li;
            Program pobj = new Program();
            li = pobj.TodosOsFuncionarios();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.Id);
                Assert.IsNotNull(x.Nome);
                Assert.IsNotNull(x.Salario);
                Assert.IsNotNull(x.Sexo);

                Console.Out.Write("Amiga do céu, meu boy me largou, parou de seguir, ai que raiva que eu tô");
            }
        }

        [Test]
        public void TestarLogin()
        {
            Program pobj = new Program();
            string x = pobj.Login("Germano", "1234");
            string y = pobj.Login("", "");
            string z = pobj.Login("Admin", "Admin");
            Assert.AreEqual("O usuário ou senha não podem ser vazios.", y);
            Assert.AreEqual("Usuário ou senha incorreta.", x);
            Assert.AreEqual("Bem vindo, Admin.", z);
        }

        [Test]
        public void CapturarInformaçõesDoFuncionario()
        {
            Program pobj = new Program();
            var p = pobj.DetalhesDosFuncionarios(100);
            foreach (var x in p)
            {
                Assert.AreEqual(x.Id, 100);
                Assert.AreEqual(x.Nome, "Bharat");
            }
        }
    }
}