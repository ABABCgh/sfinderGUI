@echo off
echo waiting powershell...
cd ..\..\..\..
powershell -NoProfile -ExecutionPolicy Unrestricted .\setup.ps1
echo quit...
exit