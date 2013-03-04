Project Hardware
=======================

This folder includes information such as user manuals and data sheets for hardware that has been, will be, or is being used for this project. The hardwares are listed below and more information about each can be found in the folder of the same name.

Arduino Uno R3
----------------------
The Arduino Uno is a mainstay in the community and famed for being very easy to use. 

[Manufacture's Link](http://arduino.cc/en/Main/arduinoBoardUno)

![alt text](http://arduino.cc/en/uploads/Main/ArduinoUno_R3_Front_450px.jpg "Arduino Uno R3")

_Image from http://arduino.cc/en/Main/arduinoBoardUno_

Stellaris Launch Pad LM4F120XL
-------------------------------
Much more powerful than an Arduino and with a nice environment using either TI's Code Composer Studio or gcc and Makefiles. This is overpowered for this application, but it was available from previous projects. It includes such niceties as on chip debugging and nested interrupt routines that make life a lot easier. Its based on a CortexM4.

[Manufacture's Link](http://www.ti.com/tool/ek-lm4f120xl)

![alt text](http://venturebeat.files.wordpress.com/2012/11/stellaris-launchpad.jpg?w=558&h=393 "Stellaris LM4F120XL")

_Image from http://venturebeat.files.wordpress.com/_

STM32VLDISCOVERY Discovery STM32F100
------------------------------
Cheapest of the bunch and with many more pins than either, this is likely be the chip that will be used. It uses a processor of similar power to that of the Launchpad, but lacks the completely unnecessary DSP instructions. It requires use of licensed 3rd party tools, but there seems to be some solid documentation on getting it to work under an standard cygwin/GNU Linux environment. The later will be the goal.

[Manufacture's Link](http://www.st.com/web/catalog/tools/FM116/SC959/SS1532/PF250863)

![alt text](http://www.st.com/st-web-ui/static/active/en/fragment/product_related/rpn_information/board_photo/board_stm32vl_discovery.jpg "stm32v1")

_Image from http://www.st.com/web/catalog/tools/FM116/SC959/SS1532/PF250863 _
