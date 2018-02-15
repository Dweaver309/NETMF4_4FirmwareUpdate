Imports Microsoft.SPOT.Hardware
Imports System.IO.Ports
Imports System.Runtime.InteropServices

Namespace STM

    Public Class STM

        Public Sub New()

            HardwareProvider.Register(New STM32F411REHardwareProvider())

        End Sub

        Private NotInheritable Class STM32F411REHardwareProvider
            Inherits HardwareProvider
            
        End Class
    End Class

        Public Class Pin

        Public Const GPIO_NONE As Cpu.Pin = Cpu.Pin.GPIO_NONE

        Public Const PA0 As Cpu.Pin = CType(((0 * 16) + 0), Cpu.Pin)

        Public Const PA1 As Cpu.Pin = CType(((0 * 16) + 1), Cpu.Pin)

        Public Const PA2 As Cpu.Pin = CType(((0 * 16) + 2), Cpu.Pin)

        Public Const PA3 As Cpu.Pin = CType(((0 * 16) + 3), Cpu.Pin)

        Public Const PA4 As Cpu.Pin = CType(((0 * 16) + 4), Cpu.Pin)

        Public Const PA5 As Cpu.Pin = CType(((0 * 16) + 5), Cpu.Pin)

        Public Const PA6 As Cpu.Pin = CType(((0 * 16) + 6), Cpu.Pin)

        Public Const PA7 As Cpu.Pin = CType(((0 * 16) + 7), Cpu.Pin)

        Public Const PA8 As Cpu.Pin = CType(((0 * 16) + 8), Cpu.Pin)

        Public Const PA9 As Cpu.Pin = CType(((0 * 16) + 9), Cpu.Pin)

        Public Const PA10 As Cpu.Pin = CType(((0 * 16) + 10), Cpu.Pin)

        Public Const PA11 As Cpu.Pin = CType(((0 * 16) + 11), Cpu.Pin)

        Public Const PA12 As Cpu.Pin = CType(((0 * 16) + 12), Cpu.Pin)

        Public Const PA13 As Cpu.Pin = CType(((0 * 16) + 13), Cpu.Pin)

        Public Const PA14 As Cpu.Pin = CType(((0 * 16) + 14), Cpu.Pin)

        Public Const PA15 As Cpu.Pin = CType(((0 * 16) + 15), Cpu.Pin)

        Public Const PB0 As Cpu.Pin = CType(((1 * 16) + 0), Cpu.Pin)

        Public Const PB1 As Cpu.Pin = CType(((1 * 16) + 1), Cpu.Pin)

        Public Const PB2 As Cpu.Pin = CType(((1 * 16) + 2), Cpu.Pin)

        Public Const PB3 As Cpu.Pin = CType(((1 * 16) + 3), Cpu.Pin)

        Public Const PB4 As Cpu.Pin = CType(((1 * 16) + 4), Cpu.Pin)

        Public Const PB5 As Cpu.Pin = CType(((1 * 16) + 5), Cpu.Pin)

        Public Const PB6 As Cpu.Pin = CType(((1 * 16) + 6), Cpu.Pin)

        Public Const PB7 As Cpu.Pin = CType(((1 * 16) + 7), Cpu.Pin)

        Public Const PB8 As Cpu.Pin = CType(((1 * 16) + 8), Cpu.Pin)

        Public Const PB9 As Cpu.Pin = CType(((1 * 16) + 9), Cpu.Pin)

        Public Const PB10 As Cpu.Pin = CType(((1 * 16) + 10), Cpu.Pin)

        Public Const PB11 As Cpu.Pin = CType(((1 * 16) + 11), Cpu.Pin)

        Public Const PB12 As Cpu.Pin = CType(((1 * 16) + 12), Cpu.Pin)

        Public Const PB13 As Cpu.Pin = CType(((1 * 16) + 13), Cpu.Pin)

        Public Const PB14 As Cpu.Pin = CType(((1 * 16) + 14), Cpu.Pin)

        Public Const PB15 As Cpu.Pin = CType(((1 * 16) + 15), Cpu.Pin)

        Public Const PC0 As Cpu.Pin = CType(((2 * 16) + 0), Cpu.Pin)

        Public Const PC1 As Cpu.Pin = CType(((2 * 16) + 1), Cpu.Pin)

        Public Const PC2 As Cpu.Pin = CType(((2 * 16) + 2), Cpu.Pin)

        Public Const PC3 As Cpu.Pin = CType(((2 * 16) + 3), Cpu.Pin)

        Public Const PC4 As Cpu.Pin = CType(((2 * 16) + 4), Cpu.Pin)

        Public Const PC5 As Cpu.Pin = CType(((2 * 16) + 5), Cpu.Pin)

        Public Const PC6 As Cpu.Pin = CType(((2 * 16) + 6), Cpu.Pin)

        Public Const PC7 As Cpu.Pin = CType(((2 * 16) + 7), Cpu.Pin)

        Public Const PC8 As Cpu.Pin = CType(((2 * 16) + 8), Cpu.Pin)

        Public Const PC9 As Cpu.Pin = CType(((2 * 16) + 9), Cpu.Pin)

        Public Const PC10 As Cpu.Pin = CType(((2 * 16) + 10), Cpu.Pin)

        Public Const PC11 As Cpu.Pin = CType(((2 * 16) + 11), Cpu.Pin)

        Public Const PC12 As Cpu.Pin = CType(((2 * 16) + 12), Cpu.Pin)

        Public Const PC13 As Cpu.Pin = CType(((2 * 16) + 13), Cpu.Pin)

        Public Const PC14 As Cpu.Pin = CType(((2 * 16) + 14), Cpu.Pin)

        Public Const PC15 As Cpu.Pin = CType(((2 * 16) + 15), Cpu.Pin)

        
    End Class

    Public Class ArduinoPin

        Public Const A0 As Cpu.Pin = Pin.PA0

        Public Const A1 As Cpu.Pin = Pin.PA1

        Public Const A2 As Cpu.Pin = Pin.PA4

        Public Const A3 As Cpu.Pin = Pin.PB0

        Public Const A4 As Cpu.Pin = Pin.PC1

        Public Const A5 As Cpu.Pin = Pin.PC0

        Public Const D0 As Cpu.Pin = Pin.PA3

        Public Const D1 As Cpu.Pin = Pin.PA2

        Public Const D2 As Cpu.Pin = Pin.PA10

        Public Const D3 As Cpu.Pin = Pin.PB3

        Public Const D4 As Cpu.Pin = Pin.PB5

        Public Const D5 As Cpu.Pin = Pin.PB4

        Public Const D6 As Cpu.Pin = Pin.PB10

        Public Const D7 As Cpu.Pin = Pin.PA8

        Public Const D8 As Cpu.Pin = Pin.PA9

        Public Const D9 As Cpu.Pin = Pin.PC7

        Public Const D10 As Cpu.Pin = Pin.PB6

        Public Const D11 As Cpu.Pin = Pin.PA7

        Public Const D12 As Cpu.Pin = Pin.PA6

        Public Const D13 As Cpu.Pin = Pin.PA5
    End Class

    Public Class ButtonPins

        Public Const User As Cpu.Pin = Pin.PC13
    End Class

    Public Class LedPins

        Public Const Led1 As Cpu.Pin = Pin.PA5
    End Class

    Module SerialPorts

        Public Const COM1 As String = Serial.COM1

        Public Const COM2 As String = Serial.COM2

        Public Const COM3 As String = Serial.COM3
    End Module

    Module BaudRates

        Public Const BaudrateNONE As BaudRate = BaudRate.BaudrateNONE

        Public Const Baud75 As BaudRate = BaudRate.Baudrate75

        Public Const Baud150 As BaudRate = BaudRate.Baudrate150

        Public Const Baud300 As BaudRate = BaudRate.Baudrate300

        Public Const Baud600 As BaudRate = BaudRate.Baudrate600

        Public Const Baud1200 As BaudRate = BaudRate.Baudrate1200

        Public Const Baud2400 As BaudRate = BaudRate.Baudrate2400

        Public Const Baud4800 As BaudRate = BaudRate.Baudrate4800

        Public Const Baud9600 As BaudRate = BaudRate.Baudrate9600

        Public Const Baud19200 As BaudRate = BaudRate.Baudrate19200

        Public Const Baud38400 As BaudRate = BaudRate.Baudrate38400

        Public Const Baud57600 As BaudRate = BaudRate.Baudrate57600

        Public Const Baud115200 As BaudRate = BaudRate.Baudrate115200

        Public Const Baud230400 As BaudRate = BaudRate.Baudrate230400
    End Module

    Module SpiDevices

        Public Const SPI1 As SPI.SPI_module = SPI.SPI_module.SPI1

        Public Const SPI2 As SPI.SPI_module = SPI.SPI_module.SPI2

        Public Const SPI3 As SPI.SPI_module = SPI.SPI_module.SPI3

        Public Const SPI4 As SPI.SPI_module = SPI.SPI_module.SPI4
    End Module
End Namespace

