using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIocTest
{
    /// <summary>
    /// Unity IOC单例模式 
    /// </summary>
    public class UnitySingleton
    {
        //单例
        private static UnitySingleton instance;

        //ioc容器
        public IUnityContainer container;

        //获取单例
        public static UnitySingleton getInstance()
        {
            if (instance == null || instance.container == null)
            {
                string configFile = "Unity.config";
                var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
                //从config文件中读取配置信息
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                //获取指定名称的配置节
                UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection("unity");
                instance = new UnitySingleton()
                {
                    //container = new UnityContainer().LoadConfiguration((UnityConfigurationSection)ConfigurationManager.GetSection("unity"), "MyContainer")
                    container = new UnityContainer().LoadConfiguration(section, "MyContainer")
                    //container = new UnityContainer()
                };
                //instance.container.RegisterType<IExampleClass, ExampleClass>();
            }
            return instance;
        }

        //IOC注入实体
        public static T GetInstanceDAL<T>()
        {
            return getInstance().container.Resolve<T>();
        }
    }
}
