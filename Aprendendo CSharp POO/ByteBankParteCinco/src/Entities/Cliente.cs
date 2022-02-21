namespace ByteBankParteCinco.src.Entities
{
    public class Cliente
    {
        public string? Nome { get; set; }
        private string _cpf;
        public string? CPF 
        {
             get
             {
                 return _cpf;
             } 
             set
             {
                 _cpf = value;
             } 
        }
        public string? Profissao { get; set; }
        
    }
}