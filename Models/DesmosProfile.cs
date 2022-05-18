using Agon.Website.GraphQL;

namespace Agon.Website.Models
{
    public class DesmosProfile
    {
        public DesmosProfile() { }
        public DesmosProfile(IGetDesmosProfileByChainLink_Chain_link_Profile profile)
        {
            DTag = profile.Dtag;
            ProfilePicture = profile.Profile_pic;
        }

        #region Properties

        public string? Address { get; set; }
        public string? Bio { get; set; }
        public string? CoverPicture { get; set; }
        public string? DTag { get; set; }
        public string? Nickname { get; set; }
        public string? ProfilePicture { get; set; }

        public string ProfileLink => $"https://explorer.desmos.network/@{DTag}";

        #endregion Properties
    }
}