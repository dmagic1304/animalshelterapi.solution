# _Animal Shelter_

#### By _**Dominik Magic**_

#### _An Animal Shelter API that serves as a database for animals stationed in the shelter._<p>&nbsp;</p>  

## Technologies Used

- HTML
- C#
- .NET 6.0
- ASP.Net
- Razor
- MySQL
- MySQL Workbench
- EF Core
- API Versioning
- Swagger

## Description

_A Web API for animal shelter. It provides endpoints for the user to retrieve animals from the shelter. In addition to retriving individual animals and lists of animals, the user can also post new animals to the database or update and delete animals currently in the base._

## Setup/Installation Requirements

* _Clone [this](https://github.com/dmagic1304/animalshelterapi.solution) repositiory to your desktop_
* _Using your terminal, navigate to the cloned project folder located on your desktop_
* _Once inside of the root folder, first create .gitignore file with "touch .gitignore" command and then use "echo "*/obj/ */bin/ */appsettings.json */appsettings.*.json" > .gitignore" command to ignore necessary folders/files_
* _Now navigate to Factory folder with "cd AnimalShelterApi" and then create appsettings.json file with "touch appsettings.json" command. Use the following command to fill the file with necessary data (make sure to ender your personal MySQL password instead of [YOURPASSWORD]):
```
echo '{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animalshelter_api;uid=root;pwd=[YOURPASSWORD];"
  }
}' > appsettings.json
```
* _Next create appsettings.Development.json file with "touch appsettings.Development.json" command. Use the following command to fill the file with necessary data:
```
echo '{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}' > appsettings.Development.json
```
* _Next, in the same "root/AnimalShelterApi" directory, run the following command: "dotnet ef database update" to create the database_


* _To test out the API endpoints in Swagger, make sure you are in  "root/AnimalShelterApi" folder using your terminal and once there, run "dotnet watch run" command in the terminal. This will open up a new tab in your browser with Swagger displayed_

## API Documentation
* Note: example endpoints listed below are applicable to cats table, simply replace .../dogs/.. with .../cats/..

### Endpoints for GET
| Endpoints Example                     | Required | Returns                                    |
| ---------------------------------|------ | ------------------------------------------ |
| api/v1/dogs                         | Required| All dogs                               |
| api/v1/dogs/1                       | Id Required | A dog with id = 1                     |
| api/v1/dogs?name=Rex              | Optional| Dogs filtered by name                  |
| api/v1/dogs?breed=husky     | Optional| Dogs filtered by description           |
| api/v1/dogs?age=7                | Optional| Dogs filtered by age          |
#### Combining Query Example
| Endpoints Example                       | Returns                                    |
| --------------------------------------- | ------------------------------------------ |
| api/v1/dogs?name=rex&age=3    | Dogs filtered by name and age  |
### Endpoints for POST
| Endpoints                               | Request Body Example                                     |
| --------------------------------------- | ------------------------------------------ |
| api/v1/dogs                         | { "name": "Craig", "breed": "Husky", "age": 7 } |
### Endpoints for PUT
| Endpoints                               | Request Body Example                                     |
| --------------------------------------- | ------------------------------------------ |
| api/v1/dogs                         | { "dogId": 3, "name": "Rex", "breed": "Husky", "age":7 } |
### Endpoints for DELETE
| Endpoints Example                       | Result                                     |
| --------------------------------------- | ------------------------------------------ |
| api/v1/dogs/3                      | Deletes a dog with id = 3      |

## Versioning

The API has versioning implemented and is currently set up to v1, or version 1 of the API. The API is set up in a way that will display the current/latest version in the URL with /v1/. Versioning will help with making it easire to do changes and upgrades to the API by not necessarily forcing existing users to apply the changes, but simply remain using the older version if that suits their needs better

## Known Bugs

* _Swagger will not list out the documentation for all the versions of the API at the moment, only the most recent one_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) _2023_ _Dominik Magic_

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.