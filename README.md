# Pluto

This project is an API that lets a rover navigate in any planet, which in this case is Pluto.

This API receives a string which contains letters indicating the moves that rover should do.


For example:
To command the rover to go in front, the string should only contain the letter "F".

The valid commands can be "F", "B", "L" or "R".
The F stands for "Forward", B stands for " Backwards", L stands for "Left" and R for "Right".

The interaction with this API is through an only endpoint which is 
```
/pluto/coordinates?moves=F
```
where the F is one of valid movements for the rover and the HTTP request type is PUT.

The pluto has a default grid which is 100x100 and it has its own obstacles.
The obstacles are static because they belong to Pluto only.

Everytime that the rover finds one obstacle it reports it along with the coordinates where rover stands stuck at.


### Run the project

- clone the project
- change directory to the folder where project has been cloned (cd <directory_name>)
- run the project via terminal with 
 ```
 dotnet run --project pluto.rover.api/pluto.rover.api/pluto.rover.api.csproj
 ```
 
 The application will be running at localhost, port 5000
