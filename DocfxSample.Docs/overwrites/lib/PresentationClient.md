---
uid: DocfxSample.ClassLib.Clients.PresentationClient
title: PresentationClient page with additional info
name: PresentationClient (what you'll want to use)
---

You can use this to add additional information to an automatically generated page without having to "contaminate" your codebase with lots of additional information like examples.  
This way you can keep your code clean, but add extra info to the generated page, while still keeping the page automatically up to date with your source code.

You can find which properties you can change in the YAML header above in [Docfx's documentation](https://dotnet.github.io/docfx/tutorial/intro_overwrite_files.html#managed-reference-model)

## Example
```cs
var client = new PresentationClient("https://example.com/api/v1");
var presentations = await client.GetAll();
foreach (var presentation in presentations)
    Console.WriteLine($"{presentation.Title} by {presentation.Speaker}");
```
