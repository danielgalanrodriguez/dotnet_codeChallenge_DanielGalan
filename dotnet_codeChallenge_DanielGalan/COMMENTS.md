# dotnet_codeChallenge_DanielGalan comments
Some comments about different things of the project

##Database
'Users' table has a unique email attribute to avoid repeating the same email.
When deleting a user, all the purchases of the deleted user will be deleted too.


## User registration
I assume that the password is already encrypted. In the examples it is not encrypted to keep it simple.

## Register purchase
I have decided that the get request to get a certain purchase must hit the endpoint /api/purchase?user_id=1 instead of /api/purchase/1 to avoid possible confusions. 

## Json production
The Json produced contains only one key with all the response data. I wanted to return a Json with all the key:value pairs this would be my goal if I had more time.
