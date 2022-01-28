using LudusBet.GraphQL;
using LudusBet.Models;

namespace LudusBet.Services
{
    public class DesmosService
    {
        #region Fields

        private readonly DesmosClient _desmosClient;

        #endregion Fields

        #region Constructors

        public DesmosService(DesmosClient desmosClient)
        {
            _desmosClient = desmosClient;
        }

        #endregion Constructors

        #region Properties

        public DesmosProfile? DesmosProfile { get; set; }

        #endregion Properties

        #region Methods

        public async Task<DesmosProfile> GetProfileByAddress(string address)
        {
            if (DesmosProfile == null)
            {
                var result = await _desmosClient.GetDesmosProfileByAddress.ExecuteAsync(address);

                DesmosProfile = new DesmosProfile { Address = result.Data?.Profile_by_pk?.Address };
            }

            return DesmosProfile;
        }

        #endregion Methods
    }
}