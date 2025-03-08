using ProjetoGrpc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<GreeterService>();
app.MapGrpcService<UsuarioService>();

app.MapGet("/", () => "Servidor gRPC em execu��o.");

app.Run();
