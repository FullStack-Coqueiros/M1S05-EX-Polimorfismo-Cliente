namespace exercicio1
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public PessoaFisica(int id, string endereco, string nome, string cpf) : base(id, endereco)
        {
           Nome = nome;
           CPF = cpf; 
        }

        public override void ExibirCliente(){
            base.ExibirCliente();
            Console.WriteLine($"Nome={Nome}, CPF={CPF}");
        }
    }
}