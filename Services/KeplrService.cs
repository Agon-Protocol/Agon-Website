using LudusBet.Models;
using LudusBet.Shared.Dialogs;
using Microsoft.JSInterop;
using MudBlazor;

namespace LudusBet.Services
{
    public class KeplrService
    {
        #region Fields

        private readonly IConfiguration _config;
        private readonly ErrorService _errorService;
        private readonly IDialogService _dialogService;
        private readonly IJSRuntime _js;

        #endregion Fields

        #region Constructors

        public KeplrService(IJSRuntime js, IConfiguration config, IDialogService dialogService, ErrorService errorService)
        {
            _js = js;
            _config = config;
            _errorService = errorService;
            _dialogService = dialogService;
        }

        #endregion Constructors

        #region Properties

        public KeplrAccount? Account { get; set; }

        #endregion Properties

        #region Methods

        public async Task ConnectKeplrAccount()
        {
            try
            {
                string? networkAddress = await _js.InvokeAsync<string?>("ludus.connectKeplr", _config["Networks:Juno:ChainId"]);
                if (networkAddress == null)
                {
                    _dialogService.Show<InstallKeplrDialog>("Warning");
                }
                else
                {
                    Account = new KeplrAccount
                    {
                        Address = networkAddress
                    };
                }
            }
            catch(JSException ex)
            {
                if(ex.Message.StartsWith("Request rejected"))
                    return;
                _errorService.ProcessError(ex);
            }
            catch(Exception ex)
            {
                _errorService.ProcessError(ex);
            }
        }

        public void Logout()
        {
            Account = null;
        }

        #endregion Methods
    }
}