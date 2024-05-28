## User state support

An abstraction for user state management for balazor

**Nuget Package Abstraction**
```
Install-Package Zonit.Extensions.Identity.Abstractions 
```
![NuGet Version](https://img.shields.io/nuget/v/Zonit.Extensions.Identity.Abstractions.svg)
![NuGet](https://img.shields.io/nuget/dt/Zonit.Extensions.Identity.Abstractions.svg)


**Nuget Package Extensions**
```
Install-Package Zonit.Extensions.Identity
```
![NuGet Version](https://img.shields.io/nuget/v/Zonit.Extensions.Identity.svg)
![NuGet](https://img.shields.io/nuget/dt/Zonit.Extensions.Identity.svg)

**Install**
Add this in ``Routes.razor``
```razor
@using Zonit.Extensions

<ZonitIdentityExtension />
```

Services in ``Program.cs``
```cs
builder.Services.AddIdentityExtension();
```
App in ``Program.cs``
```cs
app.UseIdentityExtension();
```