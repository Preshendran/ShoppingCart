Shopping Cart Web API

Features:
Adding new items to the shopping cart
Update details of existing items in shopping cart. Example: quantity
Fetching details of an item
Removing items from the cart.
All data needs to be stored in a relational database
Secured using an OAuth 2.0

##Requirements: 
###Login and be authenticated via a third party OAuth2 service - 
####Google and facebook

###Shopping cart items scopped to user which is logged in- 
####Persist logged in users
####Only that user can see their cart
####Only that user can perform actions on their cart

###Shopping cart items must have images.
####Must have mechanism to upload and attachan image to an item

###Swagger Interface to interact with the API and document each endpoint along with supported response types.

###Model Validation

###Unit testing

###Relational database to store the applicable data.



###CRUD endpoints for the shopping cart management
####Add Item to cart
####Get Cart Items - include metadata by calling get item - store: userID, cartID, ItemID
####Get Items - details of all items in stock - include current stock count.
####Get Item - take in a ID and return details of item
####Update Item
####Update details - quantity of item in cart

