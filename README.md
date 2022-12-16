# Pierre's Order Tracking

#### Tracking Vendors and Orders

#### By Alex Johnson

## Technologies Used

* CSharp
* .NET 6
* MSTest

## Description
* Use Razor to display information on each page.
<!-- * Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include. -->
<!-- * Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include. -->
<!-- * The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page. -->
*The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
*Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
*Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".



## Setup/Installation Requirements

* Clone this repo & navigate to the root directory
* open a command line prompt
* build the project using $dotnet build
* execute code with $dotnet run

dev note:
* to run tests, cd to the ProjectTests folder
* enter $dotnet test to run tests
* keep all dots in names, dont forget to update .gitignore

## Known Bugs

* If you find additional bugs not listed here, please email me at alex.johnson293@gmail.com with the subject **[_Repo Name_] Bug** and include:
  * BUG: _A brief description of the bug_
  * FIX: _Suggestion for solution (if you have one!)_
  * If you'd like to be credited, please also include your **_github user profile link_**

## Additional Thanks


## Future implementations


## License
MIT License

Copyright (c) 2022 Alex Johnson

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS 
BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE
OR OTHER DEALINGS IN THE SOFTWARE.