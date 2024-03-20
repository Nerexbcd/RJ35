using RJ35.Models;

namespace RJ35.Models.ComponentsViewModels
{
    public class NotificationDropdownViewModel
    {
        private readonly UserNotifications _notification;
        private readonly RJ35WebUser _user;

        public int Id { get { return _notification.Id; } }
        public string UserId { get { return _user.Id; } }
        public string? UserName { get { return _user.UserName; } }
        public string Content { get { return _notification.Content; } }
        public bool IsRead { get { return _notification.IsRead; } }

        public NotificationDropdownViewModel(UserNotifications Notification, RJ35WebUser User) {
            _notification = Notification;
            _user = User;
        }
    }
}
