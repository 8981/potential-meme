namespace Cataloguer.Models.ViewModel
{
    public class CatalogerModel
    {
        public int Id { get; set; }
        public List<CategoryModel>? Categories {get; set;}
        public List<MovieModels>? Movies {get; set;}
    }
}