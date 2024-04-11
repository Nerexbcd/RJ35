using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RJ35.Models;

public class AccountViewModel
{
    private readonly RJ35WebUser _RJ35WebUser;
    public readonly IEnumerable<UserAddress> UserAddresses;
    public readonly IEnumerable<UserCard> UserCards;

    public string UserName { get { return _RJ35WebUser.UserName; } }
    public string Email { get { return _RJ35WebUser.Email; } }
    public string ProfileImg { get { return _RJ35WebUser.ProfileImg; } }

    public AccountViewModel(RJ35WebUser RJ35WebUser, IEnumerable<UserAddress> _UserAddresses, IEnumerable<UserCard> _UserCards)
    {
        _RJ35WebUser = RJ35WebUser;
        UserAddresses = _UserAddresses;
        UserCards = _UserCards;
    }
}