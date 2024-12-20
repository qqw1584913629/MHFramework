set WORKSPACE=..
set LUBAN_DLL=%WORKSPACE%\Luban\Tools\Luban\Luban.dll
set CONF_ROOT=.

dotnet %LUBAN_DLL% ^
    -t all ^
    -c cs-simple-json ^
    -d json ^
    --conf %WORKSPACE%\Luban\MiniTemplate\luban.conf ^
    -x outputCodeDir=../Assets/Generate/Csharp ^
    -x outputDataDir=../Assets/Bundles/Configs

pause