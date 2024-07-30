# OData-WebAPI-Example
Shows how a simple crud-based ASP.NET Core Web API can utilize OData to expand functionality

[Microsoft Docs Tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio)

# Projects
## TodoApi
This is the main project that contains the Web API. It is a simple CRUD-based API that allows you to create, read, update, and delete todo items.
### API Structure
| API Endpoint                    | Description                    | Request Body | Response Body       |
|---------------------------------|--------------------------------|--------------|---------------------|
| GET /api/todoitems	             | Get all to-do items	           | None         | List of To-do items |
| GET /api/todoitems/{id}	        | Get a to-do item by id         | None         | To-do item	         |
| POST /api/todoitems	            | Create one or more to-do items | To-do item	  | To-do item	         |
| PUT /api/todoitems/{id}	        | Update a to-do item by id      | To-do item	  | None                |
| DELETE /api/todoitems/{id}    	 | Delete a to-do item by id      | None         | None                |
