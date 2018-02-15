# NETMF4_4FirmwareUpdate
How to build NETMF 4.4 firmware

IMPORTANT: 
The directory tree should look like this when the environment is complete.

![Screenshot](https://github.com/Dweaver309/NETMF4_4FirmwareUpdate/blob/master/Dir.png)

1. Install Microsoft Visual Studio 2015
 https://go.microsoft.com/fwlink/?LinkId=532606&clcid=0x409
  <p>***** Important Note: If you want to use Visual Basic you will need to this bug fix update
  ***** https://github.com/Dweaver309/VBFix/blob/master/README.md</p>

2. Install Microsoft Micro Framework 4.4 SDK
 https://github.com/NETMF/netmf-interpreter/releases/download/v4.4-RTW-20-Oct-2015/MicroFrameworkSDK.MSI


3.  Create this directory C:\netmf

4. Install the .NET Micro Framework Cryptographic Libraries to this directory C:\netmf\cryptic
 https://github.com/NETMF/netmf-interpreter/releases/download/NETMFCryptoLibraries/NetMFCryptoLibs.msi

5. Install the binary tools to this directory C:\netmf\
  http://netmf.github.io/downloads/build-tools.zip

6. Create this directory c:\gcc_4_9_3 and unzip the CGG ARM compiler into the directory.
  https://launchpad.net/gcc-arm-embedded/4.9/4.9-2015-q3-update/+download/gcc-arm-none-eabi-4_9-2015q3-20150921-win32.zip
   
7. Create a directory c:\net4_4_0 and unzip the .NET Micro Framework Interpreter into the directory
  https://github.com/valoni/netmf-interpreter
  
 <p>****Note this is a forked https://github.com/NETMF/netmf-interpreter by Valon M Hoti
 ****He was essential in my understanding this process. Thanks for your patience Valon!
 ****This fork also contains a port for the STM32F411 NUCLEO</p>

8. Download the CMSIS tools (rename the file extention ".pack" to ".zip" and unzip them in the c:\net4_4_0\
   The directory tree should look like this C:\netfm\netfm4_4_0\CMIS\
  https://github.com/ARM-software/CMSIS_5/releases/download/5.2.0/ARM.CMSIS.5.2.0.pack
 

9. Create a batch file in the c:\net4_4_0 called GCC.STM32F411NUCLEO.bat with the text below 
    <p>call setenv_gcc 4.9.3 "C:\netmf\gcc_4_9_3"
    call cd Solutions\STM32F411NUCLEO
    msbuild /t:build /p:flavor=release;memory=flash /fl
    call %SystemRoot%\explorer.exe "C:\netmf\netmf4_4_0\BuildOutput\THUMB2FP\GCC4.9\le\FLASH\release\STM32F411NUCLEO\bin" </p>

10. Click on the GCC.STM32F411NUCLEO.bat file the build will start and should take around 10 minutes.
 The build files will be in the C:\netmf\netmf4_4_0\BuildOutput\THUMB2FP\GCC4.9\le\FLASH\release\STM32F411NUCLEO\bin directory.

11. When the build is complete rename tinybooter.hex to tinybooter.s19 the ST DfuSe v3.0.5 File Manager will not compile the .hex file
to a .dfu file.
 
11. The ER_CONFIG and ER_FLASH files are located here: C:\netmf\netmf4_4_0\BuildOutput\THUMB2FP\GCC4.9\le\FLASH\release\EspruinoWifi11\bin\tinyclr.hex

12. When the build is complete delete or rename the BuildOutput directory. 

12. To update your computer follow the Firmware update instructions.
https://github.com/Dweaver309/UpdateFirmware

 13. Your new project will need a Hardware Provider class file to define the proccessor's pins.
 I have copied Valon Hoti's file and translated it for Visual Basic users the files can be downloaded here.

We're done!


