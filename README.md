# MicroComponents
## Exploration into a modular approach for an ASP.NET Core application

> Commits attempt to match each milestone to see each solution build from scratch

### Milestone 1
Include a simple blazor component, contained in a razor class library, in an existing ASP.NET Core MVC app

#### Advantages
Blazor component and be developed and tested by a separate team.
#### Disadvantages to current implementation
Parent project (ASP.NET Core host) requires reference to the component library.


### Milestone 2
Obtain ViewModel from Proxy API, using a Proxy Client

#### Advantages
Responsibility for building the ViewModel is delegated to a service, which goes through our (contrived) Proxy API
#### Disadvantages to current implementation
Parent project (ASP.NET Core host) requires knowledge of:
- ViewModel shape, acheived here with reference to shared project
- Knowledge of and reference to a service client to make the build ViewModel build call



