# ThreeLayerArchitecture

This project demonstrates a three-layer architecture implementation, which is a software design pattern that organizes the application into three main logical layers: the Presentation Layer, the Business Logic Layer, and the Data Access Layer.

## Project Structure

The project is structured as follows:

- `PresentationLayer/`: Contains the user interface components
- `BusinessLogicLayer/`: Implements the business logic and rules
- `DataAccessLayer/`: Handles data persistence and retrieval


## Prerequisites

- .NET 5.0 SDK or later
- Visual Studio 2019 or later (recommended) or any other C# IDE

## How to Run the Project

1. Clone the repository:
2. Open terminal
3. Run Command `dotnet run --project 'name of the project'`

## Project Contents

1. **Presentation Layer**: This layer is responsible for handling user interactions and displaying data. It contains:
   - User interface components (e.g., forms, views)
   - Input validation
   - Formatting of output data

2. **Business Logic Layer**: This layer contains the core functionality and business rules of the application. It includes:
   - Business logic and rules
   - Data processing and calculations
   - Coordination between the Presentation and Data Access layers

3. **Data Access Layer**: This layer is responsible for interacting with the database or external data sources. It handles:
   - CRUD operations (Create, Read, Update, Delete)
   - Data retrieval and persistence
   - Database connection management

4. **Props**: This directory contains the data models used across all layers. These models represent the structure of the data used in the application.



## Benefits of Three-Layer Architecture

- Separation of concerns
- Improved maintainability and scalability
- Enhanced reusability of components
- Easier testing and debugging
- Flexibility to change or upgrade individual layers without affecting others

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct and the process for submitting pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.