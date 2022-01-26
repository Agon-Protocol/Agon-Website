using LudusBet.Models;
using Microsoft.JSInterop;

namespace LudusBet.Services
{
    public class DesmosService
    {
        #region Fields

        private readonly IConfiguration _config;
        private readonly IJSRuntime _js;

        #endregion Fields

        #region Constructors

        public DesmosService(IJSRuntime js, IConfiguration config)
        {
            _js = js;
            _config = config;
        }

        #endregion Constructors

        #region Properties

        public DesmosProfile? DesmosProfile { get; set; }

        #endregion Properties

        #region Methods

        public async Task<DesmosProfile> GetProfile(string user)
        {
            return await _js.InvokeAsync<DesmosProfile>("desmosClient.getProfile", user);
        }

        public async Task InitializeAsync()
        {
            await _js.InvokeVoidAsync("initializeDesmosClient", _config["Networks:Desmos:RPC"]);
        }

        #endregion Methods
    }
}