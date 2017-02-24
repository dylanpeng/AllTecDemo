using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTest
{
    public class MSMQManager
    {
        public string _path;
        public MessageQueue _msmq;

        public MSMQManager(string path = null)
        {
            if (string.IsNullOrEmpty(path))
            {
                _path = ConfigurationManager.AppSettings["MsmqPath"].ToString();
            }
            else
            {
                _path = path;
            }
            if (MessageQueue.Exists(_path))
            {
                _msmq = new MessageQueue(_path);
            }
            else
            {
                _msmq = MessageQueue.Create(_path);
            }
        }

        public void Send(object body)
        {
            _msmq.Send(new Message(body, new XmlMessageFormatter(new Type[] { typeof(MsmqData) })));
        }

        public object ReceiveMessage()
        {
            var msg = _msmq.Receive();
            if (msg != null)
            {
                //msg.Formatter = new BinaryMessageFormatter();
                msg.Formatter = new XmlMessageFormatter(new Type[] { typeof(MsmqData) });
                var body = (MsmqData)msg.Body;
                Console.WriteLine("消息内容：{0},{1}", body.Id, body.Name);
                return msg.Body;
            }
            return null;
        }

        public void WriteAllMessage()
        {
            var enumerator = _msmq.GetMessageEnumerator2();
            while (enumerator.MoveNext())
            {
                Message msg = (Message)(enumerator.Current);
                //msg.Formatter = new BinaryMessageFormatter();
                msg.Formatter = new XmlMessageFormatter(new Type[] { typeof(MsmqData) });
                var body = (MsmqData)msg.Body;
                Console.WriteLine("消息内容：{0},{1}", body.Id, body.Name);
                _msmq.ReceiveById(msg.Id);

            }
        }

        //public bool Create()
        //{
        //    if (MessageQueue.Exists(_path))
        //        return true;

        //    if (MessageQueue.Create(_path) != null)
        //    {
        //        return true;
        //    }
        //    return false;   
        //}
    }

    [Serializable]
    public class MsmqData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
