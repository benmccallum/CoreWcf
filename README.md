CoreWeb
=======
<!--[![Build status](https://ci.appveyor.com/api/projects/status/an3ae5b27guf47iu)](https://ci.appveyor.com/project/benmccallum/coreweb)-->

A library of core helpers, extensions, constants, enums and other useful things for .NET WCF projects.

## Get it on NuGet!

    Install-Package CoreWcf
	
	
## Features
### Add CORS support to your services
The CoreWcf assmembly contains all you need to add CORS support to WCF endpoints.
It contains the classes described [here](http://enable-cors.org/server_wcf.html), so add the web.config changes as described using

```
<add name="crossOriginResourceSharingBehavior" type="CoreWcf.Behaviors.EnableCrossOriginResourceSharingBehavior, CoreWcf" />
```

as the new behaviour.
