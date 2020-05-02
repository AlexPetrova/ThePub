## Setup and run
* You need to have installed and running SQL server 
* Add you connection string in the placeholder in `appsettings.json`
* Apply migrations by running `update-database` in the `Package Manager Console`
* You are ready to go :) 

## Missing functionality
* Validation if the user has already made an order for the day.
* Cancel order.
* Orders stats.

## What can be done better
* Unit tests.
* User friendly client-side validations.  
* Server-side validations for the created orders - count of ordered meals, valid ids etc.
* Logic for adding additional meals according to the role of the user to be more extensible. 
