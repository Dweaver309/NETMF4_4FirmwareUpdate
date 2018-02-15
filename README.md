# NETMF4_4FirmwareUpdate
How to build NETMF 4.4 firmware

IMPORTANT: 
The directory tree should look like this when the environment is complete.

![Screenshot](https://github.com/Dweaver309/NETMF4_4FirmwareUpdate/blob/master/Dir.png)

1. Install Microsoft Micro Framework 4.4 SDK
 https://github.com/NETMF/netmf-interpreter/releases/download/v4.4-RTW-20-Oct-2015/MicroFrameworkSDK.MSI

2. Install Microsoft Visual Studio 2015
 https://github.com/NETMF/netmf-interpreter/releases/download/v4.4-RTW-20-Oct-2015/NetMFVS14.vsix

3.  Create this directory C:\netmf

4. Install the .NET Micro Framework Cryptographic Libraries to this directory C:\netmf\cryptic
 https://github.com/NETMF/netmf-interpreter/releases/download/NETMFCryptoLibraries/NetMFCryptoLibs.msi

5. Install the binary tools to this directory C:\netmf\
 The directory will look like this after the binary tools install
 c:\netmf\cryptic
 c:\netmf\bin
 c:\netmf\tools
 http://netmf.github.io/downloads/build-tools.zip

 6. Create this directory c:\gcc_4_9_3 and unzip the CGG ARM compiler into the directory.
   https://developer.arm.com/open-source/gnu-toolchain/gnu-rm/downloads/6-2017-q1-update
   select the download Windows ZIP File: gcc-arm-none-eabi-6-2017-q1-update-win32-zip.zip

7.Create a directory c:\net4_4_0 and unzip the .NET Micro Framework Interpreter into the directory
 https://github.com/valoni/netmf-interpreter
  
****Note this is a forked https://github.com/NETMF/netmf-interpreter by Valon M Hoti
****He was essential in my understanding this process. Thanks for your patience Valon!
****This fork also contains a port for the STM32F411 NUCLEO

8. Create a batch file in the c:\net4_4_0 called GCC.STM32F411NUCLEO.bat with the text below 
    call setenv_gcc 4.9.3 "C:\netmf\gcc_4_9_3"
    call cd Solutions\STM32F411NUCLEO
    msbuild /t:build /p:flavor=release;memory=flash /fl
    call %SystemRoot%\explorer.exe "C:\netmf\netmf4_4_0\BuildOutput\THUMB2FP\GCC4.9\le\FLASH\release\STM32F411NUCLEO\bin" 

9. Click on the GCC.STM32F411NUCLEO.bat file the build will start and should take around 10 minutes.
 The build files will be in the C:\netmf\netmf4_4_0\BuildOutput\THUMB2FP\GCC4.9\le\FLASH\release\STM32F411NUCLEO\bin directory.

10. When the build is complete tinybooter.hex to tingbooter.s19 the ST DfuSe v3.0.5 File Manager will not compile the .hex file
to a .dfu file.
 
11. The ER_CONFIG and ER_FLASH files are located here: C:\netmf\netmf4_4_0\BuildOutput\THUMB2FP\GCC4.9\le\FLASH\release\EspruinoWifi11\bin\tinyclr.hex

12. When the build is complete delete or rename the BuildOutput directory. 

12. To update your computer follow the Firmware update instructions.
https://github.com/Dweaver309/UpdateFirmware

Were done!


