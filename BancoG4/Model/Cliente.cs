namespace Model
{
    public class Cliente
    {
        public int id {  get; set; }

        public string razonSocial { get; set; }
        
        public DateTime Alta { get; set; }
        
        public DateTime Cuit { get; set; } = DateTime.Now;
        
        public string calle {  get; set; }
        
        public string departamento { get; set; }
        
        public int numero { get; set; }
        
        public string localidad { get; set; }
    }
}
