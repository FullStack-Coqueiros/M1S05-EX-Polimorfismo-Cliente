namespace exercicio1
{
    public abstract class Cliente
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        
        public Cliente(int id, string endereco)
        {
            Id = id;
           Endereco = endereco;
        }

        //public abstract void ExibirCliente();
        // public virtual void ExibirCliente(){
        // }
        public virtual void ExibirCliente(){
            Console.Write($"Endereco={Endereco}, Id = {Id}");
        }
    }
}