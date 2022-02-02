using LudusBet.Models;
using LudusBet.Shared.Dialogs;
using Microsoft.JSInterop;
using MudBlazor;

namespace LudusBet.Services
{
    public class KeplrService : StateContainer
    {
        #region Fields

        private readonly IConfiguration _config;
        private readonly ErrorService _errorService;
        private readonly IDialogService _dialogService;
        private readonly IJSRuntime _js;
        private readonly DesmosService _desmosService;

        #endregion Fields

        #region Constructors

        public KeplrService(IJSRuntime js, IConfiguration config, IDialogService dialogService, DesmosService desmosService, ErrorService errorService)
        {
            _js = js;
            _config = config;
            _errorService = errorService;
            _dialogService = dialogService;
            _desmosService = desmosService;
        }

        #endregion Constructors

        #region Properties

        private KeplrAccount? _account;

        public KeplrAccount? Account
        {
            get => _account; set
            {
                _account = value;
                NotifyStateChanged();
            }
        }

        #endregion Properties

        #region Methods

        public async Task ConnectKeplrAccount()
        {
            try
            {
                KeplrKey? keplrKey = await _js.InvokeAsync<KeplrKey?>("ludus.connectKeplr", _config["Networks:Juno:ChainId"]);
                if (keplrKey is null)
                {
                    _dialogService.Show<InstallKeplrDialog>("Warning");
                }
                else
                {
                    Account = new KeplrAccount
                    {
                        Address = keplrKey.Bech32Address,
                        Name = keplrKey.Name,
                    };

                    _desmosService.DesmosProfile = null;
                    if (keplrKey.Bech32Address != null)
                        await _desmosService.ConnectDesmosProfileByExternalAddress(keplrKey.Bech32Address);
                }
            }
            catch (JSException ex)
            {
                if (ex.Message.StartsWith("Request rejected"))
                    return;
                _errorService.ProcessError(ex);
            }
            catch (Exception ex)
            {
                _errorService.ProcessError(ex);
            }
        }

        public void LogOut()
        {
            Account = null;
            _desmosService.LogOut();
        }

        #endregion Methods
    }
}