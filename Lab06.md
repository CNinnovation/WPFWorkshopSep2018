# More Data Binding

## MultiBinding

* Create a Person class with multiple properties, e.g. FirstName and LastName
* Use MultiBinding with a StringFormat to display multiple properties within a TextBlock control

## PriorityBinding

* Create a data class that returns data after a blocking delay with Thread.Sleep
* Bind the data class to the UI - what's the result of the blocking delay?
* Use a PriorityBinding to avoid blocking and display intermediate results from a Info class

## Validation

* Create a data type that throws exceptions when a wrong value is set
* Validate binding to the UI by setting the ValidatesOnExceptions property
* Try using the IDataErrorInfo interface instead of throwing exceptions
* Implement the INotifyDataErrorInfo and display errors after a delay
