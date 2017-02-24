using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTest
{
    /// <summary>
    /// 消息队列管理对象
    /// </summary>
    public class MSMQManager
    {
        /// <summary>
        /// 消息队列地址
        /// </summary>
        public string _path;
        /// <summary>
        /// 消息队列对象
        /// </summary>
        public MessageQueue _msmq;

        /// <summary>
        /// 构造函数并初始化消息队列对象
        /// </summary>
        /// <param name="path"></param>
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

        /// <summary>
        /// 发送消息队列
        /// </summary>
        /// <param name="body"></param>
        public void Send(object body)
        {
            _msmq.Send(new Message(body, new XmlMessageFormatter(new Type[] { typeof(MsmqData) })));
        }

        /// <summary>
        /// 接受队列中第一个消息后删除
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 遍历消息队列中的消息并删除
        /// </summary>
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
                //根据消息ID查询并删除消息队列
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

    /// <summary>
    /// 消息实体
    /// </summary>
    [Serializable]
    public class MsmqData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
