# RocketNetV2

Note in order to run this project you'll probably need to install (sql express 2012 localdb) a message should pop up from VS 
when you first try to run the project. It says there's a way to update the database connection, but I couldn't figure it out.

Just added a folder of all pokemon images to the repo.

Also here's a link to the tutorial that I followed to set up this website. 
https://docs.microsoft.com/en-us/aspnet/web-forms/overview/getting-started/getting-started-with-aspnet-45-web-forms/introduction-and-overview

EDIT: 4/9/18 
Here's what's left to do.

Update Welcome page message,
Update contact and about page as well,
Remove all wingtips/old site references,
add a search bar to search by name,
update each's pokemon product data. (description, price, etc...),
possibly change the product model so pokemon can be of multiple types (not necessary),
possibly change each pokemon's product ID to match that of the pokedex (not necessary),
I'm not sure what else you guys would want to change on the site, (post any ideas here),

Edit 4/13/18
I've added pokedex entries and prices to the pokemon. All pokemon related model data should be done.
Still need remove all references of the wingtips toys site. (ctrl-f all wingtips references to find them)
Anything else not mentioned from the previous edit still hasn't been tackled.

Edit 4/25/18
Trouble Shooting (Getting Login and Checkout to work)
Make sure you pull the latest version of our project. If you're reading this you probably have.

Registering and Login should work on the website as is, to get Google login to you'll have to...
Go to the project's solution explorer in visual studio,
Right click on the project and go to properties,
on the left there should be a web tab, click on it and go to project url,
change the url to https://localhost:44300/ ctrl-s to save the change

You may need to also install Microsoft.Owin 3.00 as well. I'm not entirely sure
To do this once again right click on the project in the solution explorer in visual studio
go to manage Nuget packages... and search for Microsoft.Owin
install it, make sure to install the 3.0 version. (I'm not sure if version 3.00 matters tbh)

If you're still having issues, with login or the checkout process let me know - Genaro
 


