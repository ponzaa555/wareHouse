

dotnet ef dbcontext scaffold "server=localhost;port=3306;userid=root;password=Pon912545;Database=warehouse;" Pomelo.EntityFrameworkCore.MySql --output-dir Entity --force --use-database-names --no-pluralize --context-dir ../WarehouseSecuriryInfrastructure/Repository --context-namespace  WarehouseSecuriryInfrastructure --context SecurityContext



