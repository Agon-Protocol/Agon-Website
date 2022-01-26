using LudusBet.Models;
using Microsoft.JSInterop;

namespace LudusBet.Services
{
    public class KeplrService
    {
        #region Fields

        private readonly IConfiguration _config;
        private readonly DesmosService _desmosService;
        private readonly IJSRuntime _js;

        #endregion Fields

        #region Constructors

        public KeplrService(IJSRuntime js, IConfiguration config, DesmosService desmosService)
        {
            _js = js;
            _config = config;
            _desmosService = desmosService;
        }

        #endregion Constructors

        #region Properties

        public KeplrAccount? Account { get; set; }

        #endregion Properties

        #region Methods

        public async Task ConnectKeplrAccount()
        {
            Account = new KeplrAccount
            {
                Address = await _js.InvokeAsync<string>("connectKeplr", _config["Networks:Juno:ChainId"]),
                //ProfileAddress = await _js.InvokeAsync<string>("connectKeplr", _config["Networks:Desmos:ChainId"])
            };
            if (Account.ProfileAddress != null)
                await _desmosService.GetProfile(Account.Address);
        }

        public void Logout()
        {
            Account = null;
        }

        #endregion Methods
    }
}