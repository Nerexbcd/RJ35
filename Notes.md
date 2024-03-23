# Notes:

## Identity needs to have the claim tables

It was hard to discover, if you use the AspNetCore.Identity, You are obligated to have the claim tables, due to the fact that AspNetCore.Identity is based on a claim based authorization system. If you don't have the claim tables, the project won't work.

### References:

> ## ClaimsIdentity Class
> 
> Beginning with .NET Framework 4.5, Windows Identity Foundation (WIF) and claims-based identity have been fully integrated into the .NET Framework. This means that many classes that represent an identity in the .NET Framework now derive from ClaimsIdentity and describe their properties through a collection of claims. This is different from previous versions of the .NET Framework, in which, these classes implemented the IIdentity interface directly. 
>
> Source: [ClaimsIdentity Class](https://learn.microsoft.com/en-us/dotnet/api/system.security.claims.claimsidentity?view=net-8.0) 

> ## StackOverflow Question
>
> No, you can't have Identity framework without claims, as it sets the principal to be ClaimsPrincipal. But if you don't need/want claims, you just don't have to use it anywhere. And authentication through roles will still work. If you don't want to have UserClaims table in database, you'll have to implement your own user store that does not have claims table. However, I think this is too much effort just not to have an empty table in a db.
>
> Source: [StackOverflow](https://stackoverflow.com/a/25887121/23406953)