# Garage Backend Project

This is a backend project for a Garage application. The project focuses on implementing interfaces in C# and building small backend functionalities for managing electric and gas vehicles in a garage.

## Project Overview

The project consists of the following components:

- `Garage` namespace: Contains the main project code.
- `Program` class: Entry point of the application. It demonstrates the usage of electric and gas vehicles in the garage.
- `IElectric` interface: Represents the contract for electric vehicles. It defines properties and methods related to electric vehicles, such as battery charge level and battery charging functionality.
- `IGas` interface: Represents the contract for gas vehicles. It defines properties and methods related to gas-powered vehicles, such as fuel level and refueling functionality.
- `Zero` class: Represents an electric motorcycle. It implements the `IElectric` interface and provides specific implementations for properties and methods related to electric motorcycles.
- `Cessna` class: Represents a propeller light aircraft. It implements the `IGas` interface and provides specific implementations for properties and methods related to gas-powered aircraft.

## Usage

To run the project, follow these steps:

1. Clone the project repository to your local machine.
2. Open the project in your preferred C# development environment (e.g., Visual Studio, Visual Studio Code).
3. Build the project to ensure all dependencies are resolved.
4. Run the `Program` class to execute the application.
5. The application will showcase the usage of electric and gas vehicles, including printing their current charge/fuel levels and performing charging/refueling operations.

Feel free to explore and modify the code to suit your requirements. You can add more vehicle types, extend functionalities, or integrate the backend with a frontend application.

## Dependencies

The project has the following dependencies:

- C# 8.0 or later
- .NET Framework 4.7.2 or later

Make sure you have the necessary dependencies installed and configured in your development environment before running the project.

## Contributing

Contributions to this project are welcome! If you find any issues, have suggestions, or want to add new features, feel free to open an issue or submit a pull request.

Please adhere to the project's code style and conventions when contributing.

## License

This project is licensed under the [MIT License](LICENSE). You are free to use, modify, and distribute the code for personal or commercial purposes.

## Contact

If you have any questions or need further assistance, please feel free to contact the project maintainer at [email address].

Happy coding!
