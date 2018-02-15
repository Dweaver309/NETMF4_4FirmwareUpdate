call setenv_gcc 4.9.3 "C:\netmf\gcc_4_9_3"

call cd Solutions\STM32F411NUCLEO

msbuild /t:build /p:flavor=release;memory=flash /fl

call %SystemRoot%\explorer.exe "C:\netmf\netmf4_4_0\BuildOutput\THUMB2FP\GCC4.9\le\FLASH\release\STM32F411NUCLEO\bin" 