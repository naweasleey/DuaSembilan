namespace DuaSembilan.Models
{
    public class Sepatu //langkah pertama yaitu membuat class sepatu di folder models
    {
        public JenisSepatu JenisSepatu { get; set; }

        public Sepatu(JenisSepatu jenisSepatu) 
        {
            JenisSepatu = jenisSepatu;
        }
    }
}
