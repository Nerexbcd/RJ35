using RJ35.Models;
using RJ35.Data.Identity;

namespace RJ35.Models.ComponentsViewModels
{
    public class NotificationDropdownViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }

        public NotificationDropdownViewModel(UserNotifications un, RJ35WebUser n) {
            Id = un.Id;
            UserId = n.Id;
            UserName = n.UserName;
            Content = un.Content;
            IsRead = un.IsRead;
        }
    }
}
