var builder = DistributedApplication.CreateBuilder(args);
var scriptName = Environment.OSVersion.Platform == PlatformID.Win32NT ? "aspire-win" : "aspire-osx";


var ui =  builder.AddNpmApp("spike-angularaspire-ui", "../Spike.AngularAspire.WebUI", scriptName:scriptName)
    .WithHttpEndpoint(44312,env:"PORT")
    .WithExternalHttpEndpoints();

builder.Build().Run();
