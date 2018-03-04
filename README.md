# SAFinalProj

This project is begun as a simple .NET Core MVC Web Application, with authorization locallty for single users selected - 
same as can be started from VS 2017 on your desktop.  We will be modifying it to suit our use as an 
MVC web application with a basic sensor hub for pulling in data from sensors for eventual serving to end users.

# Goals
Show data of different sources being pulled into our database. Securely serve the data to end users.

# Needs
/ Sensor Hub
Create a simple .NET Core MVC Web App and add simple polymorphic class that will 
parse and filter two file types and add the data to our database
link to sample data .csv files https://www.wellnessbear.com/Blog/Post/433/Fitbit-Sample-Datasets 

Should we try to find another file (XML?) of sample sensor data from a different device?  Or is one sample data source 
good with a mocked API?

Not sure how we "show" the sensor hub "working". Have it print to command line, to a view (the latter seems odd)?

/ There is a controller scaffolded under the Services folder such that it would be called by the sensors using GET/POST/etc.,
and then write to the DB we set-up.  One of us needs to write a mock that will load a file (the one above) instead, as well as 
implement some methods for uploading actual API calls into the DB.

/ Database. For this implementation we should just show a RDBMS as we're so pressed for time. 
Ultimately, it would probably be beneficial to use a stream processor and non relational storage. 
This is much simplified by the .NET stack, we just need to decide what we want to do; local sql database, link it to Azure, etc.
For now it will go into our each persons local DBContexts that VS supplies by default (under Data).  

/ Views. This is made much simpler by the .NET Core stack, but will need UI design and functionality for pulling 
and putting data into the database from the views. Under the Views folder, all of the Home folder views need to be changed
or deleted.

/ File Folders to Add/Delete/Update classes

Models - Only need to add classes

Views - All views under the Home folder need to be changed or deleted, nothing else should be altered.  Adding is OK.

Controllers - Depending on view changes, Home controller may need to be changed (it's only doing stuff for the top margin tabs).  
Otherwise, only additional classes.

Data - Downstream further we'll need to add DB connections, but this would be one of us (and may not be necessary)

Services - I added SensorHubController and had it auto-scaffold.  It needs to be written as our SensorHub stub/mock.  No other 
changes needed.  Additional classes OK.

No other changes should be needed until we get to dealing with Database stuff (appsettings.json will need to be updated, etc)
