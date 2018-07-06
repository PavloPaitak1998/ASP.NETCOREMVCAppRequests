# ASP.NET CORE MVC App Requests
A simple ASP .NET Core MVC App on C# which makes HTTP request on server and retrieves some JSON data and then deserializes it to use linq requests, all data must be rendered into HTML page.
## To successfully do it you will need:

#### 1) Create an ASP.NET MVC Core application from the Visual Studio template

#### 2) Use HttpClient (or WebClient) to receive a set of the open data by means of API of requests to https://5b128555d50a5c0014ef1204.mockapi.io/:endpoint

Where _endpoint_ can have the following values:
     
     users

     posts

     comments

     todos

      address
   #### 3) Present the received data as a set of entities (nested objects).
     -Users
 
     --- Posts
 
     ------- Comments
 
     --- Todos
 
#### 4) To deserialize, use [Newtonsoft](https://www.newtonsoft.com/json).

#### 5) Entities must be connected. 

    In order to determine the relationship, you must use id. To create a hierarchy, 
    use Join () from Linq. - implement a set of methods for retrieving data from 
    the collection (or several collections, depending on the query)

#### 6) List of requests:

      1. Get the number of comments under the posts of a particular user (on aidi) (list from post-number)

      2. Get a list of comments under the posts of a particular user (on aide), where body comment <50 characters (list of comments)

      3. Get the list (id, name) from the list of todos that are executed for a specific user (by IDE)

      4. Get a list of users in alphabetical order (ascending) with sorted todo items by length name (descending)

      5. Get the following structure (pass User Id to parameters)

          * User

          * Last post by user (by date)

          * Number of comments under the last post

          * Number of unfulfilled tasks for the user

          * The most popular user post (where most of the comments with a text length of more than 80 characters)

          * The most popular user post (where most of the likes)

      6. Get the following structure (pass the Id post to the parameters)

          * Post

          * The longest comment of the post

          * The most lukewarm comment on the post

          * Number of comments under the post where or 0 likes or text length <80
    
#### 7) For each sample, create a separate page (select the samples from the previous job)

#### 8) The results of queries are displayed in tables. 

    If the table row assumes nested data, then make it possible to expand 
    the attached data into another small table (expand / collapse).

#### 9) The navigation between the pages should be carried out through the menu.

#### 10) Creativity task: 
    create a page where all the original data will be displayed in a beautiful way,
    i.e. Users with their posts and comments under them, and so on.
    
#### 11) For entities User, Post, Todo, separate pages should be created to view the information. In other places of the application, the user name, the name of the post, the name of the todo-item should be clickable and lead to the entity page.    
    
### Attention

1) _**Each sample must be performed in one method.**_
2) _**Pay attention to the general style, layout. The application should not be rejected by its appearance. Creativity is welcome.**_   
### Have fun :)
