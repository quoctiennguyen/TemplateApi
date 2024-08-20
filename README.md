# TemplateApi
Explanation of the Structure:
- Controllers/: Contains the API controllers that handle HTTP requests and responses.
  - ProductsController.cs: Manages CRUD operations for Product entities.
- Data/: Contains the DbContext class which manages the database connection and entity sets.
  - AppDbContext.cs: Defines the database context and DbSet properties.
- Models/: Contains the entity classes that represent the data model.
  - Product.cs: Represents the Product entity.
- Repositories/: Contains the repository interfaces and their implementations for data access.
  - IProductRepository.cs: Interface defining the contract for product data operations.
  - ProductRepository.cs: Implementation of the IProductRepository interface.
- Services/: Contains the service interfaces and their implementations for business logic.
  - IProductService.cs: Interface defining the contract for product business logic.
  - ProductService.cs: Implementation of the IProductService interface.
- Properties/: Contains project-specific settings.
- launchSettings.json: Configuration for launching the application.
- appsettings.json: Configuration file for application settings, including database connection strings.
- Program.cs: Entry point of the application.
- Startup.cs: Configures services and the app's request pipeline.