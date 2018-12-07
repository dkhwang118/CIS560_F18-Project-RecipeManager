CIS 560 - Project Team 01

NOTE: No specific data generation .sql scripts were used to create the default data or to populate 
the database with randomly generated data. Small amounts of default data was inserted into the tables through
the "Server Explorer" functionality in Visual Studio 2017 to check the basic queries against persistent data,
but the majority of the data seen in the application is randomly generated upon load using the 
"DataGenerator" class, defined in the "DataGenerator.cs" file. Loading of this generated data can be prevented 
by commenting-out line 35 in the "HomeController.cs" file.