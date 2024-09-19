<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">


	<targets>

		<target
			name="logConsole" xsi:type="Console" layout="${date} | ${level:uppercase=true} | ${message}${exeption:format=tostring}" />
		

		<target
			name="logFile" xsi:type="File" fileName ="logFile.txt" layout="${longdate} | ${level} | ${message}" />
		


	</targets>

	<!-- Указываем правила (rules) для определения, какие логи попадут в какие цели -->
	<rules>
		<!-- Правило для записи всех логов в консоль -->
		<logger name="*" minlevel="Trace" writeTo="logConsole" />

		<!-- Правило для записи всех логов в файл -->
		<logger name="*" minlevel="Trace" writeTo="logFile" />
	</rules>
</nlog>