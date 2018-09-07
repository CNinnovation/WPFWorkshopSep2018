# Lab 5 - Data Binding

## Element to Element Binding

* Create a Canvas Element with a few shapes
* Add sliders to the page
* Use element-to-element binding to move the Canvas element
* Use element-to-element binding to resize the Canvas

## Object Binding

* Create a model class defining a few properties, e.g. a Book class with Title and Publisher properties - you can create your own types as well
* Create a service that returns one instance of the previously created model type
* Use the ObjectDataProvider to instantiate the service and invoke the method
* Create TextBox controls that bind to properties of the model type
* Modify the application to use a DataContext assigned from code instead of using the ObjectDataProvider
* Add a Button with an event handler that shows the instance values from code - does the object update when it is changed from the UI? What needs to be changed to update or not update the instance from the UI?
* Add a Button with an event handler and change the model instance from code. Does it update in the UI? What needs to be changed to update it in the UI?
* Implement *INotifyPropertyChanged*

## List Binding

* Modify the service type to return a list of objects
* Add a *ListBox* in the XAML page and customize the layout
* Bind the list returned from the service to the ListBox
* Selecting an item in the ListBox, the selected item should be shown
* Create a *DataTemplate* to show items in the ListBox
