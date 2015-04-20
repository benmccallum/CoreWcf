CoreWeb
=======
[![Build status](https://ci.appveyor.com/api/projects/status/aq9spdajwtg8db5y/branch/master?svg=true)](https://ci.appveyor.com/project/benmccallum/corewcf/branch/master)

A library of core helpers, extensions, constants, enums and other useful things for .NET WCF projects.

## Get it on NuGet!

    Install-Package CoreWcf
	
	
## Features
### Add CORS support to your services
The CoreWcf assembly contains all you need to add CORS support to WCF endpoints.
It contains the classes described [here](http://enable-cors.org/server_wcf.html), so add the web.config changes as described using

```
<add name="crossOriginResourceSharingBehavior" type="CoreWcf.Behaviors.EnableCrossOriginResourceSharingBehavior, CoreWcf" />
```

as the new behaviour.
