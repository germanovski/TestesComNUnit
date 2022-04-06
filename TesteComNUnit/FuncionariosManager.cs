

namespace ControleFuncionarios
{
     public class FuncionariosManager
    {
        public virtual Funcionario AlteraNomeDoFuncionario(Funcionario ObjFuncionario)
        {
            return null;
        }

        public virtual bool CadastrarFuncionario(string nome, float salario, string sexo, BancoDeDadosManager bdManager)
        {

            if (nome.Length < 10 || !nome.Contains(' ')) throw new Exception("Nome Inválido");
            if (salario < 3000 || salario > 30000) throw new Exception("Salário Invalido");

            var novoFuncionario =  new Funcionario()
            {
                Nome = nome,
                Salario = salario,
                Sexo = sexo
            };

            return bdManager.InsereFuncionarioNoBancoDeDados(novoFuncionario);

        }

    }
}
