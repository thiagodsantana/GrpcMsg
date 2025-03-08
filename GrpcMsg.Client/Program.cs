using Grpc.Net.Client;
using ProjetoGrpc;

class Program
{
    static async Task Main()
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:7044");

        // Criando os clients
        var greeterClient = new Greeter.GreeterClient(channel);
        var usuarioClient = new Usuario.UsuarioClient(channel);

        // Chamadas gRPC
        await EnviarSaudacaoAsync(greeterClient);
        await EnviarUsuarioAsync(usuarioClient);
    }

    private static async Task EnviarSaudacaoAsync(Greeter.GreeterClient client)
    {
        try
        {
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Thiago" });
            Console.WriteLine($"[Saudação] Resposta do servidor: {reply.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Erro - SayHello] {ex.Message}");
        }
    }

    private static async Task EnviarUsuarioAsync(Usuario.UsuarioClient client)
    {
        try
        {
            var request = new UsuarioRequest
            {
                Nome = "Thiago Darlei",
                Email = "thiago.darley@gmail.com",
                Endereco = "Rua de teste"
            };

            var reply = await client.EnvioUsuarioAsync(request);
            Console.WriteLine($"[Usuário] Nome: {reply.Nome} | Email: {reply.Email} | Mensagem: {reply.Mensagem}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Erro - EnvioUsuario] {ex.Message}");
        }
    }
}
