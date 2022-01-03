namespace RESTresale.Models
{
    public class ResaleItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Seller { get; set; }
        public int Date { get; set; }
        public string PictureUrl { get; set; }

        public override string ToString()
        {
            return Id + " " + Title + " " + Price;
        }
    }
}
