using Blazored.LocalStorage;
using LudusBet.GraphQL;
using LudusBet.Models;

namespace LudusBet.Services
{
    public class DesmosService : StateContainer
    {
        #region Fields

        private readonly DesmosClient _desmosClient;
        private readonly ErrorService _errorService;
        private readonly ILocalStorageService _localStorageService;

        #endregion Fields

        #region Constructors

        public DesmosService(DesmosClient desmosClient, ErrorService errorService, ILocalStorageService localStorageService)
        {
            _desmosClient = desmosClient;
            _errorService = errorService;
            _localStorageService = localStorageService;
        }

        #endregion Constructors

        #region Properties

        private DesmosProfile? _desmosProfile;
        public DesmosProfile? DesmosProfile
        {
            get => _desmosProfile;
            set
            {
                _desmosProfile = value;
                NotifyStateChanged();
            }
        }

        #endregion Properties

        #region Methods

        public async Task ConnectDesmosProfileByExternalAddress(string address)
        {
            //already connected
            if (DesmosProfile != null)
                return;

            //check local storage first
            DesmosProfile desmosProfile = await _localStorageService.GetItemAsync<DesmosProfile>(address);

            if (desmosProfile != null)
            {
                DesmosProfile = desmosProfile;
                return;
            }

            //query desmos
            var profileQueryResult = await GetDesmosProfileByExternalAddress(address);

            if (profileQueryResult != null)
            {
                DesmosProfile = new DesmosProfile(profileQueryResult);
                await _localStorageService.SetItemAsync(address, DesmosProfile);
            }
        }

        public async Task<IGetDesmosProfileByChainLink_Chain_link_Profile?> GetDesmosProfileByExternalAddress(string address)
        {
            try
            {
                var result = await _desmosClient.GetDesmosProfileByChainLink.ExecuteAsync(address);


                if (result.Data is null || result.Data.Chain_link is null || result.Data.Chain_link.Count == 0)
                    return null;

                return result.Data.Chain_link[0].Profile;
            }
            catch (Exception ex)
            {
                _errorService.ProcessError(ex);
            }

            return null;
        }

        public void LogOut()
        {
            DesmosProfile = null;
        }

        #endregion Methods
    }
}