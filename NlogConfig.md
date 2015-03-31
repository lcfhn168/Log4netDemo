
web.config
--------------------------

```
<configuration>
 <configSections>
    <section name="nlog" type="NLog.Config.ConfigSectionHandler, NLog"/>
  </configSections>
  
  .........
  
</configuration>
```


Nlog.config
----------------------------------------
```
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

  <!-- 
  See https://github.com/nlog/nlog/wiki/Configuration-file 
  for information on customizing logging rules and outputs.
   -->
  <targets>
    <!-- add your targets here -->
    
    <!--
    <target xsi:type="File" name="f" fileName="${basedir}/logs/${shortdate}.log"
            layout="${longdate} ${uppercase:${level}} ${message}" />
    -->
  
    <target xsi:type="File" name="f" fileName="${basedir}/logs/${shortdate}.log" />
  
  
  </targets>

  <rules>
    <!-- add your logging rules here -->
    
    <!--
    <logger name="*" minlevel="Trace" writeTo="f" />
    -->
  
    <logger name="*" minlevel="Info" writeTo="f"/>
  

  </rules>
</nlog>
```



Log levels
-----------------------------------
The following are the allowed log levels (in descending order):

Off
Fatal
Error
Warn
Info
Debug
Trace
Log Levels in NLog are consistent with Log4j/Log4net, so a description of the different levels' usage on Wikipedia's entry about log4j is applicable for NLog Log Levels.
