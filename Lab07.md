# Lab 7 - MVVM

Modify the Books sample application (you can use a different data source as well) to use MVVM:

## List

1. Create the WPF Application
2. Create a User Control to display the list (folder *Views*)
3. Create a view-model for the list (folder *ViewModels*)
4. Create a service and a service contract (folder *Services*) to return a list of Book objects
5. Add the DI container *Microsoft.Extensions.DependencyInjection*
6. Register services and view-models
7. Connect view-models, services, views, display list of Book objects

## Detail-Information

1. Add another user control for the detail-information
2. View-model
3. Connect, use IEventAggregator to send messages

## Additional features

1. Add **Add** features to create new Book objects
2. Add **Update** to update existing books
3. Add **Delete** to delete books
