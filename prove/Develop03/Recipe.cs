using System;

public class Recipe
{

    private string _text;

    private List<string> _ingredients = new List<string>();

    public Recipe(string recipe) 
    {
    
        _text = recipe;
        
    }

    public string GetRecipe() 
    {
        return _text;
    }

    public void AddIngredient() 
    {
        char[] spearator = { ',' };
        string[] ingredientList = _text.Split(spearator);

        foreach(string ingredientStr in ingredientList )
        {
            _ingredients.Add(ingredientStr);
        }

    }

    public void DisplayRecipe()
    {
        foreach(string ingrediant in _ingredients)
        {
            System.Console.WriteLine(ingrediant);
        }
    }
}