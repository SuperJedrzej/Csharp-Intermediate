using System.Collections;
using System.Collections.Generic;

namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INoticifationChannel> _notificationChannel;

        public VideoEncoder()
        {
            _notificationChannel = new List<INoticifationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (var channel in _notificationChannel)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INoticifationChannel channel)
        {
            _notificationChannel.Add(channel);
        }

    }
}
