﻿using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ComponentThree;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");

var app = builder.Build();

await app.RunAsync();
