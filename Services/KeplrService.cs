using LudusBet.Models;
using Microsoft.JSInterop;

namespace LudusBet.Services
{
    public class KeplrService
    {
        private readonly IJSRuntime _js;
        private readonly IConfiguration _config;

        public KeplrService(IJSRuntime js, IConfiguration config)
        {
            _js = js;
            _config = config;
        }

        public KeplrAccount? Account { get; set; }

        public async Task ConnectKeplrAccount()
        {
            Account = new KeplrAccount
            {
                Address = await _js.InvokeAsync<string>("connectKeplrAsync", _config["ChainID"])
            };
        }

        public void Logout()
        {
            Account = null;
        }
    }
}