using Microsoft.SPOT.Hardware;
using System.IO.Ports;

namespace STM32F411RE.Hardware
{
        /// <summary>
        /// Defination of STM32F411RET board Hardware
        /// </summary>
        /// 
    /*
        Analog
        PA0,PA1,PA2,PA3,PA4,PB0,PC0,PC1,PC2,PC3
    
	
        PWM
        PA0,PA1,PA5,PA6,PA8,PA9,PA10,PA11,PA15,PB3,PB4,PB5,PB6,PB7,PB8,PB9,PB10,PC6,PC7,PC8,PC9

		
        SPI  : SPI1  SPI2  SPI3  SPI4
		------------------------------
        SCLK : PA5   PB13  PC10  PB13
        MISO : PA6   PB14  PC11  PA11
        MOSI : PA7   PB15  PC12  PA1

		
        I2C
		--------
        SCL PB8 
        SDA PB9

		
        UART : UART1   UART2   UART6 
		---------------------------
        RX   : PA10    PA3     PA12  
        TX   : PA9     PA2     PA11
        CTS  : none    PA0     none
		RTS  : none    PA1     none
		
    */

    public class STM32F411RE
        {
            static STM32F411RE()
            {
                HardwareProvider.Register(new STM32F411REHardwareProvider());
            }

            private sealed class STM32F411REHardwareProvider : HardwareProvider
            {
            }
        }

        /// <summary>
        /// Pin definitions for the STM32F411RET board
        /// </summary>
        /// 
     
        public class Pin
        {
        /// <summary>A value indicating that no GPIO pin is specified.</summary>
        public const Cpu.Pin GPIO_NONE = Cpu.Pin.GPIO_NONE;

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA0 = (Cpu.Pin)((0 * 16) + 0);  // Analog0

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA1 = (Cpu.Pin)((0 * 16) + 1); // Analog1

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA2 = (Cpu.Pin)((0 * 16) + 2); // Analog2

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA3 = (Cpu.Pin)((0 * 16) + 3); 

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA4 = (Cpu.Pin)((0 * 16) + 4); // Analog3

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA5 = (Cpu.Pin)((0 * 16) + 5);  //sclk1

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA6 = (Cpu.Pin)((0 * 16) + 6);  //miso1

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA7 = (Cpu.Pin)((0 * 16) + 7); //pw7 //mosi1

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA8 = (Cpu.Pin)((0 * 16) + 8);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA9 = (Cpu.Pin)((0 * 16) + 9);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA10 = (Cpu.Pin)((0 * 16) + 10);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA11 = (Cpu.Pin)((0 * 16) + 11);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA12 = (Cpu.Pin)((0 * 16) + 12);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA13 = (Cpu.Pin)((0 * 16) + 13);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA14 = (Cpu.Pin)((0 * 16) + 14);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PA15 = (Cpu.Pin)((0 * 16) + 15);


        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB0 = (Cpu.Pin)((1 * 16) + 0);  //pwm1 // Analog4

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB1 = (Cpu.Pin)((1 * 16) + 1);  //pwm2 // Analog5

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB2 = (Cpu.Pin)((1 * 16) + 2);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB3 = (Cpu.Pin)((1 * 16) + 3);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB4 = (Cpu.Pin)((1 * 16) + 4);  //pw3

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB5 = (Cpu.Pin)((1 * 16) + 5);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB6 = (Cpu.Pin)((1 * 16) + 6); //pw4

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB7 = (Cpu.Pin)((1 * 16) + 7); 

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB8 = (Cpu.Pin)((1 * 16) + 8); //pw5 //scl

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB9 = (Cpu.Pin)((1 * 16) + 9); //pw6 //sda

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB10 = (Cpu.Pin)((1 * 16) + 10);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB11 = (Cpu.Pin)((1 * 16) + 11);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB12 = (Cpu.Pin)((1 * 16) + 12);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB13 = (Cpu.Pin)((1 * 16) + 13);  //mosi2

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PB14 = (Cpu.Pin)((1 * 16) + 14);  //miso2

        /// <summary>Digital I/O.</summary> 
        public const Cpu.Pin PB15 = (Cpu.Pin)((1 * 16) + 15);  //sclk2



        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC0 = (Cpu.Pin)((2 * 16) + 0);  // Analog6

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC1 = (Cpu.Pin)((2 * 16) + 1); // Analog7

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC2 = (Cpu.Pin)((2 * 16) + 2); // Analog8

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC3 = (Cpu.Pin)((2 * 16) + 3); // Analog9

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC4 = (Cpu.Pin)((2 * 16) + 4);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC5 = (Cpu.Pin)((2 * 16) + 5);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC6 = (Cpu.Pin)((2 * 16) + 6);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC7 = (Cpu.Pin)((2 * 16) + 7);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC8 = (Cpu.Pin)((2 * 16) + 8);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC9 = (Cpu.Pin)((2 * 16) + 9);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC10 = (Cpu.Pin)((2 * 16) + 10);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC11 = (Cpu.Pin)((2 * 16) + 11);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC12 = (Cpu.Pin)((2 * 16) + 12);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC13 = (Cpu.Pin)((2 * 16) + 13);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC14 = (Cpu.Pin)((2 * 16) + 14);

        /// <summary>Digital I/O.</summary>
        public const Cpu.Pin PC15 = (Cpu.Pin)((2 * 16) + 15);

        /// <summary>GPIO NAME</summary>
        public static string GetPinName(Cpu.Pin pin)
        {
            if (pin == Cpu.Pin.GPIO_NONE)
                return "GPIO_NONE";

            var pinNumber = (int)pin;

            int port = pinNumber / 16;
            int num = pinNumber - 16 * port;
            string result = "P" + (char)('A' + port) + num;
            return result;
          }
        }

        public class ArduinoPin
        {
            public const Cpu.Pin A0 = Pin.PA0;
            public const Cpu.Pin A1 = Pin.PA1;
            public const Cpu.Pin A2 = Pin.PA4;
            public const Cpu.Pin A3 = Pin.PB0;
            public const Cpu.Pin A4 = Pin.PC1;
            public const Cpu.Pin A5 = Pin.PC0;

            public const Cpu.Pin D0 = Pin.PA3;
            public const Cpu.Pin D1 = Pin.PA2;
            public const Cpu.Pin D2 = Pin.PA10;
            public const Cpu.Pin D3 = Pin.PB3;
            public const Cpu.Pin D4 = Pin.PB5;
            public const Cpu.Pin D5 = Pin.PB4;
            public const Cpu.Pin D6 = Pin.PB10;
            public const Cpu.Pin D7 = Pin.PA8;
            public const Cpu.Pin D8 = Pin.PA9;
            public const Cpu.Pin D9 = Pin.PC7;
            public const Cpu.Pin D10 = Pin.PB6;
            public const Cpu.Pin D11 = Pin.PA7;
            public const Cpu.Pin D12 = Pin.PA6;
            public const Cpu.Pin D13 = Pin.PA5;
        }

        public class ButtonPins
        {
            public const Cpu.Pin User = Pin.PC13;
        }

        public class LedPins
        {
            public const Cpu.Pin Led1 = Pin.PA5;
        }

        public static class SerialPorts
        {
            public const string COM1 = Serial.COM1;
            public const string COM2 = Serial.COM2;'
			public const string COM3 = Serial.COM3;
        }

        public static class BaudRates
        {
            public const BaudRate BaudrateNONE = BaudRate.BaudrateNONE;
            public const BaudRate Baud75 = BaudRate.Baudrate75;
            public const BaudRate Baud150 = BaudRate.Baudrate150;
            public const BaudRate Baud300 = BaudRate.Baudrate300;
            public const BaudRate Baud600 = BaudRate.Baudrate600;
            public const BaudRate Baud1200 = BaudRate.Baudrate1200;
            public const BaudRate Baud2400 = BaudRate.Baudrate2400;
            public const BaudRate Baud4800 = BaudRate.Baudrate4800;
            public const BaudRate Baud9600 = BaudRate.Baudrate9600;
            public const BaudRate Baud19200 = BaudRate.Baudrate19200;
            public const BaudRate Baud38400 = BaudRate.Baudrate38400;
            public const BaudRate Baud57600 = BaudRate.Baudrate57600;
            public const BaudRate Baud115200 = BaudRate.Baudrate115200;
            public const BaudRate Baud230400 = BaudRate.Baudrate230400;
        }

        public static class SpiDevices
        {
            public const SPI.SPI_module SPI1 = SPI.SPI_module.SPI1;
            public const SPI.SPI_module SPI2 = SPI.SPI_module.SPI2;
			public const SPI.SPI_module SPI3 = SPI.SPI_module.SPI3;
			public const SPI.SPI_module SPI4 = SPI.SPI_module.SPI4;
        }

 }