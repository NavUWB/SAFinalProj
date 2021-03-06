# SAFinalProj

# Requirements

Visual Studio 2017 with ASP.net 2.0.1; the very newest update.  Available via your Microsoft Dreamspark account.

This project is begun as a simple .NET Core MVC Web Application, with authorization locally for single users selected - 
same as can be started from VS 2017 on your desktop.  We will be modifying it to suit our use as an 
MVC web application with a basic sensor hub for pulling in data from sensors for eventual serving to end users.

# Goals
Show data from different sensors/sources being pulled into our data warehouse (database for our simplified implementations). 

Securely serve the data to end users.

# Needs
/ Sensor Hub

Create a simple .NET Core MVC Web App and add api service/controller class that will accept data from sensors
parse and filter the data and add it to our database.

Link to sample data .csv files https://www.wellnessbear.com/Blog/Post/433/Fitbit-Sample-Datasets 

Should we try to find another file (XML?) of sample sensor data from a different device?  Or is one sample data source 
good with a mocked REST API?

Not sure how we "show" the sensor hub "working". Have it print to command line, to a view (the latter seems odd)?

/ There is a controller scaffolded under the Services folder called SensorHubController such that it would be called by the sensors using GET/POST/etc., and then write to a DB asynchronously.  One of us needs to code a stub that will load a file 
(the one above) instead, as well as implement some methods for mocking the actual API calls into the DB.

/ Database. For this implementation we should just show a RDBMS as we're so pressed for time. 
Ultimately, it would probably be beneficial to use a stream processor and non relational storage. 
This is much simplified by the .NET stack, we just need to decide what we want to do; local sql database, link it to Azure, etc.
For now it will go into our each persons local DBContexts that VS supplies by default (under Data). 

/ Views. This is made much simpler by the .NET Core stack, but will need UI design and functionality for pulling 
and putting data into the database from the views. Simplest would be a "sync" button that will call the SensorHubController stubbed data into the DBContext and display it.

/ File Folders to Add/Delete/Update classes

Models - Only need to add classes

Views - All views under the Home folder need to be changed or deleted, nothing else should be altered.  Adding is OK.

Controllers - Depending on view changes, Home controller may need to be changed (it's only mapping links to views).  
Otherwise, only additional classes, no deletes.

Data - DONE Need to give the database a context.  I'm really unsure of how the magic happens here, but I beleive we're mapping each model and it's associated data to a field in the database for CRUD.

Migrations - Downstream further we'll need to add DB connections, but this would only be one of us (may not be necessary).

Services - I added SensorHubController and had it auto-scaffold.  It needs to be coded as our SensorHub stub/mock - it's EMPTY.  No other changes to folder needed.  Additional classes OK.

There is a lot of stuff already, most all of it is for the log-in and email framework and support classes.
