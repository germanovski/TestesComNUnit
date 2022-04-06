namespace ControleFuncionarios
{
    public class Program
    {
        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "O usuário ou senha não podem ser vazios.";
            }
            else
            {
                if (UserId == "Admin" && Password == "Admin")
                {
                    return "Bem vindo, Admin.";
                }
                return "Usuário ou senha incorreta.";
            }
        }

        public List<Funcionario> TodosOsFuncionarios()
        {
            List<Funcionario> li = new List<Funcionario>();
            li.Add(new Funcionario
            {
                Id = 100,
                Nome = "Bharat",
                Sexo = "masculino",
                Salario = 40000
            });
            li.Add(new Funcionario
            {
                Id = 101,
                Nome = "sunita",
                Sexo = "Femasculino",
                Salario = 50000
            });
            li.Add(new Funcionario
            {
                Id = 103,
                Nome = "Karan",
                Sexo = "masculino",
                Salario = 40000
            });
            li.Add(new Funcionario
            {
                Id = 104,
                Nome = "Jeetu",
                Sexo = "masculino",
                Salario = 23000
            });
            li.Add(new Funcionario
            {
                Id = 105,
                Nome = "Manasi",
                Sexo = "feminino",
                Salario = 80000
            });
            li.Add(new Funcionario
            {
                Id = 106,
                Nome = "Ranjit",
                Sexo = "masculino",
                Salario = 670000
            });
            return li;
        }

        public List<Funcionario> DetalhesDosFuncionarios(int Id)
        {
            List<Funcionario> li1 = new List<Funcionario>();
            Program p = new Program();
            var li = p.TodosOsFuncionarios();
            foreach (var x in li)
            {
                if (x.Id == Id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }

        static void Main(string[] args) { }
    }
}