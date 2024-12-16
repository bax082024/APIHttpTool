1. GET Request
Use this endpoint to retrieve a post.

Example URL: https://jsonplaceholder.typicode.com/posts/1

{
  "userId": 1,
  "id": 1,
  "title": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
  "body": "quia et suscipit suscipit recusandae consequuntur expedita et cum..."
}

2. POST Request
This endpoint creates a new post.

Example URL: https://jsonplaceholder.typicode.com/posts

Example Payload (as JSON):
{
  "title": "foo",
  "body": "bar",
  "userId": 1
}
Response:

{
  "id": 101,
  "title": "foo",
  "body": "bar",
  "userId": 1
}

3. PUT Request
This endpoint updates an existing post.

Example URL: https://jsonplaceholder.typicode.com/posts/1

Example Payload (as JSON):
{
  "id": 1,
  "title": "updated title",
  "body": "updated body",
  "userId": 1
}
Response:

{
  "id": 1,
  "title": "updated title",
  "body": "updated body",
  "userId": 1
}

4. DELETE Request
This endpoint deletes a post.

Example URL: https://jsonplaceholder.typicode.com/posts/1

Response:

{} (The response is usually an empty object {} with a status code 200 OK.)
