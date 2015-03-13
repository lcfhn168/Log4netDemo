Log4net config 
-----------------------------


1. *.config
===============================
以按日期写日志到文件,在.config文件中添加 

```
<!--日志配置部分-->
  <configSections>
    <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler,log4net"/>
  </configSections>
 
   <log4net> 
   <appender name="RollingLogFileAppender" type="log4net.Appender.RollingFileAppender">
      <!--日志的路径-->
      <file value="log\log" />
      <!--是否覆盖，默认是追加true-->
      <appendToFile value="true"/>
      <!--文件名称-->
      <DatePattern value="yyyyMMdd &quot;.txt&quot;"></DatePattern>
      <!--设置无限备份=-1 ，最大备份数为1000-->
      <maxSizeRollBackups value="1000"/>
      <!--每个文件的最大20k-->
      <maximumFileSize value="20"/>
      <!--名称是否可以更改为false为可以更改-->
      <param name="StaticLogFileName" value="false" />
     
      <param name="RollingStyle" value="Composite" />
      <layout type="log4net.Layout.PatternLayout">
        <param name="ConversionPattern" value="%d [%r] [%t] %-5p %c  - %m%n%n" />
      </layout>
   </appender>
   
		<!-- Setup the root category, add the appenders and set the default level -->
		<root>
			<level value="ALL" /> 
			<appender-ref ref="RollingLogFileAppender" /> 
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

详细配置Demo  




