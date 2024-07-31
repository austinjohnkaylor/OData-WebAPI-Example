# OData-WebAPI-Example
Shows how a simple crud-based ASP.NET Core Web API can utilize OData to expand functionality


# Projects
## TodoApi
This is the main project that contains the Web API. It is a simple CRUD-based API that allows you to create, read, update, and delete todo items.
This [Microsoft Docs Tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio)
was used as a reference to create the API.
### API Structure
| API Endpoint                    | Description                    | Request Body | Response Body       |
|---------------------------------|--------------------------------|--------------|---------------------|
| GET /api/todoitems	             | Get all to-do items	           | None         | List of To-do items |
| GET /api/todoitems/{id}	        | Get a to-do item by id         | None         | To-do item	         |
| POST /api/todoitems	            | Create one or more to-do items | To-do item	  | To-do item	         |
| PUT /api/todoitems/{id}	        | Update a to-do item by id      | To-do item	  | None                |
| DELETE /api/todoitems/{id}    	 | Delete a to-do item by id      | None         | None                |

## TodoApi.OData
This project contains the OData configuration for the TodoApi project. It allows you to expand the functionality of the API by adding OData query options to the API endpoints.
It also follows the same API structure as the TodoApi project, but with the added functionality of OData query options.
This [Microsoft Docs Tutorial](https://learn.microsoft.com/en-us/odata/webapi/first-odata-api) was used as a reference to create the OData-based API. Also based off of [this tutorial](https://learn.microsoft.com/en-us/odata/webapi-8/getting-started?tabs=net60%2Cvisual-studio-2022%2Cvisual-studio) for OData v8.
### API Structure
| API Endpoint                    | Description                    | Request Body | Response Body       |
|---------------------------------|--------------------------------|--------------|---------------------|
| GET /api/todoitems	             | Get all to-do items	           | None         | List of To-do items |
| GET /api/todoitems/{id}	        | Get a to-do item by id         | None         | To-do item	         |
| POST /api/todoitems	            | Create one or more to-do items | To-do item	  | To-do item	         |
| PUT /api/todoitems/{id}	        | Update a to-do item by id      | To-do item	  | None                |
| DELETE /api/todoitems/{id}    	 | Delete a to-do item by id      | None         | None                |

## BasicCrudApi
This project is a simple CRUD-based API. 
This project is based off of the [Microsoft Docs Tutorial]https://learn.microsoft.com/en-us/odata/webapi-8/tutorials/basic-crud?tabs=net60%2Cvisual-studio-2022%2Cvisual-studio%2Cvs2022) Basic CRUD in ASP.NET Core OData 8