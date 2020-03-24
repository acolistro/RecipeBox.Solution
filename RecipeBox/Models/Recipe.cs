using System.Collections.Generic;

namespace RecipeBox.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.Tags = new HashSet<TagRecipe>();
        }

        public int RecipeId { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }

        public ICollection<TagRecipe> Categories { get;}
    }
}