
Run these commands 

dotnet ef migrations add InitialCreate --project ./KitchenAid --startup-project ./KitchenAid
dotnet ef database update --project ./KitchenAid

dotnet ef migrations add AddRecipesAndAllergies --project ./KitchenAid --startup-project ./KitchenAid.Console


