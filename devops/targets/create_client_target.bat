@echo off

call "%~dp0..\config.bat"

set TARGET_TYPE=Client
set MODULE_NAME=%ProjectPureName%
set TargetFileName=%MODULE_NAME%%TARGET_TYPE%.Target.cs
set TargetFilePath=%SourceCodePath%\%TargetFileName%

call "%~dp0create_target.bat"
