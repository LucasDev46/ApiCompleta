namespace DevIO.API.Extensions
{

    // classe para mapear as configurações do appsettings.json
    public class AppSettings
    {
        // configurações de autenticação
        // chave de criptografia do nosso token
        public string Secret { get; set; }
        // tempo de expiração do token em horas
        public int ExpiracaoHoras { get; set; }
        // emissor do token
        public string Emissor { get; set; }
        // url que o token é valido
        public string ValidoEm { get; set; }

    }
}
