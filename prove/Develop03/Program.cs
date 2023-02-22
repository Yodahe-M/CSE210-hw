using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
            
        int i = 1; 

        while (i != 4)
        {
            i = menu.DisplayMenu();
            

        if (i == 1)
        {

            Recipe cooky = new Recipe("\n 1/3 cup butter softened, 1/2 cup sugar, 1 large egg room temperature, 1/2 cup mashed ripe banana, 1/2 teaspoon vanilla extract, 1-1/4 cups all-purpose flour, 1 teaspoon baking powder, 1/4 teaspoon salt, 1/8 teaspoon baking soda, 1 cup semisweet chocolate chips, ");
            cooky.AddIngredient();
            cooky.DisplayRecipe();
        }

        else if (i == 2)
        {
            Recipe bananaBread = new Recipe("\n 2 cups all-purpose flour, 1 teaspoon baking soda, 1/4 teaspoon salt, 3/4 cup brown sugar, 1/2 cup butter, 2 eggs beaten, 2 1/2 cups mashed overripe bananas, ");
            bananaBread.AddIngredient();
            bananaBread.DisplayRecipe();
        }
        else if (i == 3)
        {
            Recipe friedRice = new Recipe("\n 2/3 cup chopped baby carrots, 1/2 cup frozen green peas, 2 tablespoons vegetable oil, 1 clove garlic; minced or to taste (Optional), 2 large eggs, 3 cups leftover cooked white rice, 1 tablespoon soy sauce, or more to taste, 2 teaspoons sesame oil, ");
            friedRice.AddIngredient();
            friedRice.DisplayRecipe();
        }
        }

        
        

    }
    
    
}