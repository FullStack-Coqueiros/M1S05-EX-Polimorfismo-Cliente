namespace exercicio1
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public PessoaJuridica(int id, string endereco, string razaoSocial, string cnpj):  base(id, endereco)        {
           this.RazaoSocial = razaoSocial;
           this.CNPJ = cnpj;
        }

        public override void ExibirCliente(){
            base.ExibirCliente();
            Console.WriteLine($"RazaoSocial={RazaoSocial}, CNPJ={CNPJ}");
        }
    }
}