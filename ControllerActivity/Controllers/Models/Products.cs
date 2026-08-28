namespace ControllerActivity.Controllers.Models
{
    public class Product
    {
        public int ProductId {  get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Id { get; internal set; }
    }
}
