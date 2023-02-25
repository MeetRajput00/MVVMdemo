# MVVM Demo

This repository contains a demo project showcasing the MVVM (Model-View-ViewModel) pattern in a WPF application. It consists of two views, TableView and LoginView, and implements various MVVM concepts such as INotifyPropertyChanged, ICommand, RelayCommand, and NavigationService.

The purpose of this demo is to provide an example of how to implement the MVVM pattern in a WPF application using these concepts. It is made as a demo for anyone who is learning MVVM and wants to see how these concepts can be applied in a practical setting.

## Getting Started

To run the demo, simply clone the repository and open the solution in Visual Studio. Build the solution and run the application. You will be presented with the LoginView, which allows you to enter a username and password. Upon successful login, you will be taken to the TableView, which displays a list of items.

## MVVM Concepts

This demo implements several MVVM concepts:

- **INotifyPropertyChanged**: This interface is used to notify the view when a property in the ViewModel changes. It is implemented in the ViewModelBase class, which is inherited by the ViewModel classes.
- **ICommand**: This interface is used to define commands that can be executed in the ViewModel. It is used to bind UI elements to ViewModel methods.
- **RelayCommand**: This is an implementation of ICommand that allows you to define commands in the ViewModel. It is used to bind UI elements to ViewModel methods.
- **NavigationService**: This is a service that handles navigation between views in the application. It is used to navigate between the LoginView and TableView.

## Project Structure

The project is structured as follows:

- **Models**: This folder contains the data models used in the application.
- **ViewModels**: This folder contains the ViewModel classes for each view.
- **Views**: This folder contains the XAML markup files for each view.
- **Services**: This folder contains the NavigationService implementation.
- **Commands**: This folder contains the RelayCommand implementation.

## Contributing

If you find any issues with the demo or would like to contribute to it, feel free to submit a pull request or create an issue. This demo is meant to be a learning resource for anyone interested in MVVM, so any contributions that improve the clarity or correctness of the code are welcome.

## License

This demo is licensed under the MIT License. See the LICENSE file for more information.
