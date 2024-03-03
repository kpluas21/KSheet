# KSheet

## Description

KSheet is an interactive web application made with Blazor used to log calls taken at a call center.

- This was made in an effort to save paper, trees and time!
- Allows the lead supervisors to quickly check calls 
- Enables faster searching instead of manually reading through physical sheets of paper.

## Table of Contents

- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Credits](#credits)
- [Contibuting](#contributing)

## Requirements

Make sure you have the latest version of the .NET SDK installed on the host computer. 
This will be enough to get you started developing and running the application. [.NET Downloads](https://dotnet.microsoft.com/en-us/download)

## Installation

To open the project in a development environment, simply open the .sln file with Visual Studio and build. 
Otherwise, simply run KSheet.exe and open the url in a browser of your choosing. Make sure the port listed is open to traffic. By default, it is 5000. 

## Usage

In the main 'Home' screen, you can enter values such as the address, police signal, incident number and so on. Hitting submit will enter the call into the database.

![Entering a call](assets/images/Call_entry.png)

Entering a call into the database requires at the minimum, data in the following fields
- Position
- Address
- Incident Number

In the 'Search' screen, you can attempt to look for a specific call using several fields. Be sure to enter as much information as possible for a more focused search.

![Searching for a call](assets/images/list_calls.png)

Calls are displayed in a neat table.

![Listing some calls](assets/images/table_calls.png)
## Credits

A huge thanks to [this](https://www.allhandsontech.com/programming/blazor/how-to-sqlite-blazor/) tutorial which really made the foundation for this application. I mostly repurposed it for a different use and added the searching functions. 


## Badges

![badmath](https://img.shields.io/github/languages/top/lernantino/badmath)


## Contributing

If you have any feedback, problems, or you want to help with development, shoot me an email or create an issue!

