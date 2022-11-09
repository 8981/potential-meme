namespace Cataloguer.Models.ViewModel
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string? CategoryName {get; set;}
        public List<MovieModels>? Movies {get; set;}
    }
}