
Run these commands 

dotnet ef migrations add InitialCreate --project ./KitchenAid --startup-project ./KitchenAid
dotnet ef database update --project ./KitchenAid

dotnet ef migrations add AddRecipesAndAllergies --project ./KitchenAid --startup-project ./KitchenAid.Console

dotnet ef database update  --project ./KitchenAid --startup-project ./KitchenAid.Console

dotnet ef migrations add AddMenuAndMenuRecipe --project ./KitchenAid --startup-project ./KitchenAid.Console


----

# Use Cases
AS A  profecinal Chef
I WANT TO use stored recipes build meunus
SO THAT .... recipes can be priced, supplyers compaired, and menus evaluated.