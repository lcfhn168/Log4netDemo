Log4net config 
-----------------------------


1. *.config
===============================
以按日期写日志到文件,在.config文件中添加 

```
<!--日志配置部分-->
 <!--日志配置部分-->
  <configSections>
    <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler,log4net"/>
  </configSections>

  <log4net>

    <appender name="RollingLogFileAppender" type="log4net.Appender.RollingFileAppender">
      <!--<file value="log\log.txt"/>-->
      <!--<file name="Client.Logging" value="log\log" />-->
      <file value="log\log" /> 
      <appendToFile value="true"/> 
      <!--名称是否可以更改 为false为可以更改-->
      <param name="StaticLogFileName" value="false" />
      <!--文件名称-->
      <param name="DatePattern" value="yyyyMMdd&quot;.txt&quot;" />
      <param name="RollingStyle" value="Composite" />
      <!--<param name="RollingStyle" value="Composite" />-->
      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="记录时间：%date 线程ID:[%thread] 日志级别：%-5level 出错类：%logger property:[%property{NDC}] - 错误描述：%message%newline" />
      </layout>
    </appender>
     
    <!--定义输出到控制台命令行中-->
    <appender name="ConsoleAppender" type="log4net.Appender.ConsoleAppender">
      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date [%thread] %-5level %logger [%property{NDC}] - %message%newline" />
      </layout>
    </appender>
    
    <!-- Setup the root category, add the appenders and set the default level -->
    <root>
      <!--文件形式记录日志-->
      <appender-ref ref="RollingLogFileAppender" />
      <!--控制台控制显示日志-->
      <appender-ref ref="ConsoleAppender" />
     
    </root>
   
  </log4net>
```

2. 记录日志  
```
log4net.Config.XmlConfigurator.Configure();
//也可AssemblyInfo.cs   [assembly: log4net.Config.XmlConfigurator(Watch = true)]
log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
log.Debug("test");
```

详细配置Demo  <https://github.com/xxiu/Log4netDemo>
log4net       <http://logging.apache.org/log4net/>




