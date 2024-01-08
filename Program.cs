﻿
using CookieCookbook.App;
using CookieCookbook.DataAccess;
using CookieCookbook.FileAccess;
using CookieCookbook.Recipes.Ingredients;
using static CookieCookbook.Recipes.Recipe;



const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ? 
    new StringsJsonRepository() :
    new StringsTextualRepository();

const string FileName = "recipes";

var fileMetaData = new FileMetaData(FileName,Format); 

var ingredientsRegister = new IngredientsRegister();


var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(
        stringsRepository,
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister));
cookiesRecipesApp.Run(fileMetaData.ToPath()); 





