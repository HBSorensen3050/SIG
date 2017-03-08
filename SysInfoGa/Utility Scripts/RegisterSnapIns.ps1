set-alias installutil $env:windir\Microsoft.NET\Framework64\V4.0.30319\installutil
installutil /uninstall ..\Output\SysInfoGa.dll
installutil ..\Output\SysInfoGa.dll

Add-PSSnapIn SysInfoGaSnapIn