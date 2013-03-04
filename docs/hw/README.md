Project Hardware
=======================

This folder includes information such as user manuals and data sheets for hardware that has been, will be, or is being used for this project. The hardwares are listed below and more information about each can be found in the folder of the same name.

Arduino Uno
----------------------
The Arduino Uno is a mainstay in the community and famed for being very easy to use. 


Stellaris Launch Pad LM4F120XL
-------------------------------
Much more powerful than an Arduino and with a nice environment using either TI's Code Composer Studio or gcc and Makefiles. This is overpowered for this application, but it was available from previous projects. It includes such niceties as on chip debugging and nested interrupt routines that make life a lot easier. Its based on a CortexM4.


STM32VLDISCOVERY Discovery STM32F100
------------------------------
Cheapest of the bunch and with many more pins than either, this is likely be the chip that will be used. It uses a processor of similar power to that of the Launchpad, but lacks the completely unnecessary DSP instructions. It requires use of licensed 3rd party tools, but there seems to be some solid documentation on getting it to work under an standard cygwin/GNU Linux environment. The later will be the goal.
