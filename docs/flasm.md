Flash Decompilation With flasm
====================================
This document details the use of flasm in the research project. This aguments the development notes taken between Feb 25 and March 5.

Motivation for flasm
------------------------------------
Originally, Sothink SWF Decompiler was used to view the action script variables of interest. However, the software is only limited use ShareWare. A free open source alternative was located call flasm. While the output of the flasm program was not nearly as refined as the Sothink product, it could easily be agumented with unix style command line utilities to serve the desired purpose.

An example of flasms power when combined with \*nix commands is show below to pull the English names and details of all sensors and actuators for all swfs in a Github friendly markdown format.

```bash
for f in *.swf; do printf "\n\n"; flasm -d $f  | awk "/push *'(\w+SensNum|\w+ActNum|EDig|EAnalog|fileName|EprgName)/" | sed "s/|//g" | sed "s/ *push *'\([^,]*\)', '\([^']*\)'/|\1|\2|/g" | awk '!/\|\|/' ; done;
```

This one liner loops through all swf files in the directory. It prints a few newlines before each dump to allow table seperation and then uses and awk to print only lines where assignment takes place (*push*) and the variables of interest (Actuators, Names, Senors) are. The first sed pulls out and stray pipes before another sed formats it as a pipe dlimeted table. Blank entries were prevented form behing show due the second awk.

This is the result of the script showing the inputs and outputs along with other details for each of the swfs taken from EasyVeep.

|fileName|10.swf|
|DigSensNum|10|
|DigActNum|6|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Tape recorder|
|EDigSens1|<< previous button|
|EDigSens2|<< backward button|
|EDigSens3|>> forward button|
|EDigSens4|>> next button|
|EDigSens5|STOP button|
|EDigSens6|> play button|
|EDigSens7| pause button|
|EDigSens8|End of the tape (left side)|
|EDigSens9|Space on the tape|
|EDigSens10|End of the tape (right side)|
|EDigAct1|Start the motor|
|EDigAct2|Put the head on the tape|
|EDigAct3|Switch high speed of motor|
|EDigAct4|Switch reverse direction|
|EDigAct5|Switch off the button <<, >>|
|EDigAct6|Switch off the button STOP, PLAY|


|fileName|11.swf|
|DigSensNum|7|
|DigActNum|5|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Treasure hunt|
|EDigSens1|Treasure on red bar|
|EDigSens2|Treasure on blue bar|
|EDigSens3|Treasure on both bars (crossing)|
|EDigSens4|Start position for blue bar|
|EDigSens5|Start position for red bar|
|EDigSens6|End position for blue bar|
|EDigSens7|End position for red bar|
|EDigAct1|Move red|
|EDigAct2|Move blue|
|EDigAct3|Switch reverse direction (red)|
|EDigAct4|Switch reverse direction (blue)|
|EDigAct5|Mark the treasure|


|fileName|12.swf|
|DigSensNum|8|
|DigActNum|5|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Greenhouse|
|EDigSens1|Natural light is low|
|EDigSens2|Moisture of soil minimum|
|EDigSens3|Moisture of soil maximum|
|EDigSens4|Temperature minimum|
|EDigSens5|Temperature optimum|
|EDigSens6|Temperature maximum|
|EDigSens7|Humidity minimum|
|EDigSens8|Humidity maximum|
|EDigAct1|Light|
|EDigAct2|Irrigate|
|EDigAct3|Open the windows|
|EDigAct4|Heat|
|EDigAct5|Cooling|


|fileName|13.swf|
|DigSensNum|11|
|DigActNum|6|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Lock chamber|
|EDigSens1|Gate on the left closed|
|EDigSens2|Gate on the right closed|
|EDigSens3|Water level low|
|EDigSens4|Water level high|
|EDigSens5|Ship from left|
|EDigSens6|Ship at the left gate|
|EDigSens7|Ship in the lock-gate|
|EDigSens8|Gate on the left is open|
|EDigSens9|Gate on the right is open|
|EDigSens10|Ship at the right gate|
|EDigSens11|Ship from right|
|EDigAct1|Open the gate on left side|
|EDigAct2|Open the gate on right side|
|EDigAct3|Increase the water level|
|EDigAct4|Decrease the water level|
|EDigAct5|Free sign on left side|
|EDigAct6|Free sign on right side|


|fileName|14.swf|
|DigSensNum|6|
|DigActNum|6|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Parking Lot|
|EDigSens1|IN barrier is down|
|EDigSens2|IN barrier is up|
|EDigSens3|OUT barrier is down|
|EDigSens4|OUT barrier is up|
|EDigSens5|Car is at the barrier IN|
|EDigSens6|Car is at the barrier OUT|
|EDigAct1|IN barrier up|
|EDigAct2|OUT barrier up|
|EDigAct3|Red signal IN|
|EDigAct4|Green signal IN|
|EDigAct5|Red signal OUT|
|EDigAct6|Green signal OUT|


|fileName|tp301_1.swf|
|DigSensNum|1|
|DigActNum|1|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Lamp model|
|EDigSens1|Lamp button|
|EDigAct1|Lamp|


|fileName|tp301_2.swf|
|DigSensNum|3|
|DigActNum|1|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Cylinder model|
|EDigSens1|Start|
|EDigSens2|Piston in - end position|
|EDigSens3|Piston in + end position|
|EDigAct1|Valve for cylinder|


|fileName|15.swf|
|DigSensNum|16|
|DigActNum|16|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Simulator|
|EDigSens1|O/I Bit 0|
|EDigSens2|O/I Bit 1|
|EDigSens3|O/I Bit 2|
|EDigSens4|O/I Bit 3|
|EDigSens5|O/I Bit 4|
|EDigSens6|O/I Bit 5|
|EDigSens7|O/I Bit 6|
|EDigSens8|O/I Bit 7|
|EDigSens9|O/I Bit 8|
|EDigSens10|O/I Bit 9|
|EDigSens11|O/I Bit 10|
|EDigSens12|O/I Bit 11|
|EDigSens13|O/I Bit 12|
|EDigSens14|O/I Bit 13|
|EDigSens15|O/I Bit 14|
|EDigSens16|O/I Bit 15|
|EDigAct1|I/O Bit 0|
|EDigAct2|I/O Bit 1|
|EDigAct3|I/O Bit 2|
|EDigAct4|I/O Bit 3|
|EDigAct5|I/O Bit 4|
|EDigAct6|I/O Bit 5|
|EDigAct7|I/O Bit 6|
|EDigAct8|I/O Bit 7|
|EDigAct9|I/O Bit 8|
|EDigAct10|I/O Bit 9|
|EDigAct11|I/O Bit 10|
|EDigAct12|I/O Bit 11|
|EDigAct13|I/O Bit 12|
|EDigAct14|I/O Bit 13|
|EDigAct15|I/O Bit 14|
|EDigAct16|I/O Bit 15|


|fileName|18.swf|
|DigSensNum|8|
|DigActNum|1|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Safe|
|EDigSens1|Bit 0 of the BCD code of the digit entered|
|EDigSens2|Bit 1 of the BCD code of the digit entered|
|EDigSens3|Bit 2 of the BCD code of the digit entered|
|EDigSens4|Bit 3 of the BCD code of the digit entered|
|EDigSens5|Signal which always accompanies the entry of the BCD code|
|EDigSens6|Safe lock open|
|EDigSens7|Safe door closed|
|EDigSens8|Safe door open|
|EDigAct1|Locks safe|


|fileName|19.swf|
|DigSensNum|5|
|DigActNum|4|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Car alarm system|
|EDigSens1|Left door closed|
|EDigSens2|Right door closed|
|EDigSens3|Trunk (boot) closed|
|EDigSens4|Pushbutton for switching alarm system on|
|EDigSens5|Pushbutton for switching alarm system off|
|EDigAct1|Operates left indicator light|
|EDigAct2|Operates right indicator light|
|EDigAct3|Operates horn|
|EDigAct4|Activates alarm system|


|fileName|1.swf|
|DigSensNum|6|
|DigActNum|4|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Hot water tank|
|EDigSens1|Min. water level|
|EDigSens2|Lower water level|
|EDigSens3|Upper water level|
|EDigSens4|Max. water level|
|EDigSens5|Min. temperature|
|EDigSens6|Max. temperature|
|EDigAct1|Inlet valve (fast)|
|EDigAct2|Inlet valve (slow)|
|EDigAct3|Outlet valve|
|EDigAct4|Heating|


|fileName|20.swf|
|DigSensNum|10|
|DigActNum|7|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Control panel for cylinders|
|EDigSens1|Cylinder 1 retracted|
|EDigSens2|Cylinder 1 extended|
|EDigSens3|Cylinder 2 retracted|
|EDigSens4|Cylinder 2 extended|
|EDigSens5|Cylinder 3 retracted|
|EDigSens6|Cylinder 3 extended|
|EDigSens7|Start button|
|EDigSens8|Stop button (normally closed)|
|EDigSens9|Reset button|
|EDigSens10|Auto/manual switch|
|EDigAct1|Valve for cylinder 1|
|EDigAct2|Valve for cylinder 2|
|EDigAct3|Valve for cylinder 3|
|EDigAct4|Normal setting of lamp|
|EDigAct5|Stop lamp|
|EDigAct6|Q1 lamp|
|EDigAct7|Q2 lamp|


|fileName|21.swf|
|DigSensNum|4|
|DigActNum|1|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Press with two-hand operation|
|EDigSens1|Pushbutton for left hand|
|EDigSens2|Pushbutton for right hand|
|EDigSens3|Press cylinder in initial position|
|EDigSens4|Press cylinder in lower stop position|
|EDigAct1|Valve operating the press cylinder |


|fileName|22.swf|
|DigSensNum|1|
|DigActNum|2|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Mobile phone timer (TON)|
|EDigSens1|Pushbutton ON/OFF|
|EDigAct1|Switch on phone|
|EDigAct2|LCD backlight|


|fileName|23.swf|
|DigSensNum|6|
|DigActNum|7|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Motion detector timer (TOF)|
|EDigSens1|Motion sensor|
|EDigSens2|Ambient light sensor|
|EDigSens3|Roller shutters open (second floor)|
|EDigSens4|Roller shutters closed (second floor)|
|EDigSens5|Roller shutters open (first floor)|
|EDigSens6|Roller shutters are closed (first floor)|
|EDigAct1|External lighting|
|EDigAct2|Close roller shutters (2nd floor)|
|EDigAct3|Open roller shutters (2nd floor)|
|EDigAct4|Close  roller shutters (1st floor)|
|EDigAct5|Open roller shutters (1st floor)|
|EDigAct6|Switch on light (2nd floor)|
|EDigAct7|Switch on light (1st floor)|


|fileName|24.swf|
|DigSensNum|3|
|DigActNum|3|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Packaging of cubes - counter|
|EDigSens1|Sensor for the upper conveyor belt (green cubes)|
|EDigSens2|Sensor for the lower conveyor belt (blue cubes)|
|EDigSens3|Box not yet full|
|EDigAct1|Start upper conveyor belt|
|EDigAct2|Start lower conveyor belt|
|EDigAct3|Actuator for changing boxes|


|fileName|25.swf|
|DigSensNum|3|
|DigActNum|2|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Garage door - Pulse-edge control|
|EDigSens1|Pushbutton for remote control|
|EDigSens2|Garage door is in lower end position|
|EDigSens3|Garage door is in upper end position|
|EDigAct1|Activate motor for garage door|
|EDigAct2|Change direction of motion|


|fileName|26.swf|
|DigSensNum|6|
|DigActNum|3|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Lifting luggage|
|EDigSens1|Lifting cylinder in initial position|
|EDigSens2|Lifting cylinder extended|
|EDigSens3|Thrust cylinder in initial position|
|EDigSens4|Thrust cylinder extended|
|EDigSens5|Piece of luggage arrived|
|EDigSens6|Piece of luggage raised|
|EDigAct1|Move lifting cylinder upwards|
|EDigAct2|Move lifting cylinder to initial position |
|EDigAct3|Extend thrust cylinder|


|fileName|27.swf|
|DigSensNum|10|
|DigActNum|7|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Control panel 2 - lifting luggage|
|EDigSens1|Lifting cylinder in initial position|
|EDigSens2|Lifting cylinder extended|
|EDigSens3|Thrust cylinder in initial position|
|EDigSens4|Thrust cylinder extended|
|EDigSens5|Piece of luggage arrived|
|EDigSens6|Piece of luggage raised|
|EDigSens7|Start pushbutton|
|EDigSens8|Stop pushbutton (normally closed)|
|EDigSens9|Reset pushbutton|
|EDigSens10|Auto/manual switch|
|EDigAct1|Move lifting cylinder up|
|EDigAct2|Move lifting cylinder to initial position|
|EDigAct3|Extend thrust cylinder|
|EDigAct4|Initial position Lamp|
|EDigAct5|Stop Lamp|
|EDigAct6|Q1 Lamp|
|EDigAct7|Q2 Lamp|


|fileName|28.swf|
|DigSensNum|3|
|DigActNum|1|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Cylinder motion - signal-edge|
|EDigSens1|Cylinder in initial position|
|EDigSens2|Cylinder extended|
|EDigSens3|Pushbutton|
|EDigAct1|Valve|


|fileName|30.swf|
|DigSensNum|8|
|DigActNum|8|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|IO sim|
|EDigSens1|Output Bit 0.|
|EDigSens2|Output Bit 1.|
|EDigSens3|Output Bit 2.|
|EDigSens4|Output Bit 3.|
|EDigSens5|Output Bit 4.|
|EDigSens6|Output Bit 5.|
|EDigSens7|Output Bit 6.|
|EDigSens8|Output Bit 7.|
|EDigAct1|Input Bit 0.|
|EDigAct2|Input Bit 1.|
|EDigAct3|Input Bit 2.|
|EDigAct4|Input Bit 3.|
|EDigAct5|Input Bit 4.|
|EDigAct6|Input Bit 5.|
|EDigAct7|Input Bit 6.|
|EDigAct8|Input Bit 7.|


|fileName|2.swf|
|DigSensNum|6|
|DigActNum|3|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Three cylinders|
|EDigSens1|1st piston in - end position|
|EDigSens2|1st piston in + end position|
|EDigSens3|2nd piston in - end position|
|EDigSens4|2nd piston in + end position|
|EDigSens5|3rd piston in - end position|
|EDigSens6|3rd piston in + end position|
|EDigAct1|Valve for 1st cylinder|
|EDigAct2|Valve for 2nd cylinder|
|EDigAct3|Valve for 3rd cylinder|


|fileName|30.swf|
|DigSensNum|0|
|DigActNum|0|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|*** NEW IDEAS ***|


|fileName|3.swf|
|DigSensNum|12|
|DigActNum|5|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Elevator|
|EDigSens1|Call-button on the 0. floor|
|EDigSens2|Call-button on the 1. floor|
|EDigSens3|Call-button on the 2. floor|
|EDigSens4|Button for 0. floor (in the elevator)|
|EDigSens5|Button for 1. floor (in the elevator)|
|EDigSens6|Button for 2. floor (in the elevator)|
|EDigSens7|Elevator on 0. floor|
|EDigSens8|Elevator on 1. floor|
|EDigSens9|Elevator on 2. floor|
|EDigSens10|Door is closed on 0. floor|
|EDigSens11|Door is closed on 1. floor|
|EDigSens12|Door is closed on 2. floor|
|EDigAct1|Start the motor upwards|
|EDigAct2|Start the motor downwards|
|EDigAct3|Open the door on 0. floor|
|EDigAct4|Open the door on 1. floor|
|EDigAct5|Open the door on 2. floor|


|fileName|4.swf|
|DigSensNum|6|
|DigActNum|7|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Washing machine|
|EDigSens1|Door is closed|
|EDigSens2|Water level max.|
|EDigSens3|Temperature min.|
|EDigSens4|Water level min.|
|EDigSens5|Temperature max.|
|EDigSens6|Start|
|EDigAct1|Water inlet valve|
|EDigAct2|Heating|
|EDigAct3|Water pump (outlet valve)|
|EDigAct4|Motor switch|
|EDigAct5|High revolution|
|EDigAct6|Change direction of rotation|
|EDigAct7|Door lock|


|fileName|5.swf|
|DigSensNum|12|
|DigActNum|8|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|7-segment display|
|EDigSens1|No. 1 to display|
|EDigSens2|No. 2 to display|
|EDigSens3|No. 3 to display|
|EDigSens4|No. 4 to display|
|EDigSens5|No. 5 to display|
|EDigSens6|No. 6 to display|
|EDigSens7|No. 7 to display|
|EDigSens8|No. 8 to display|
|EDigSens9|No. 9 to display|
|EDigSens10|No. 10 to display|
|EDigSens11|No. 11 to display|
|EDigSens12|No. 12 to display|
|EDigAct1|1. segment|
|EDigAct2|2. segment|
|EDigAct3|3. segment|
|EDigAct4|4. segment|
|EDigAct5|5. segment|
|EDigAct6|6. segment|
|EDigAct7|7. segment|
|EDigAct8|2.+3. segment (for number 1)|


|fileName|6.swf|
|DigSensNum|7|
|DigActNum|8|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Bottling wine|
|EDigSens1|Bottle on the station: filling|
|EDigSens2|Bottle on the station: cork|
|EDigSens3|Bottle on the station: neck label|
|EDigSens4|Bottle on the station: label|
|EDigSens5|Sensor for dark bottle|
|EDigSens6|Sensor for white bottle|
|EDigSens7|Station is ready|
|EDigAct1|Fill red wine|
|EDigAct2|Fill white wine|
|EDigAct3|Corking|
|EDigAct4|Neck labeling red wine|
|EDigAct5|Neck labeling white wine|
|EDigAct6|Labeling red wine|
|EDigAct7|Labeling white wine|
|EDigAct8|Production line (motor)|


|fileName|7.swf|
|DigSensNum|6|
|DigActNum|3|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Ball sorting system|
|EDigSens1|Eject piston in position -|
|EDigSens2|Eject piston in position +|
|EDigSens3|Capacitive sensor|
|EDigSens4|Optical sensor|
|EDigSens5|Inductive sensor|
|EDigSens6|Ball in gravity chute|
|EDigAct1|Eject piston valve|
|EDigAct2|Gate for 1. storage|
|EDigAct3|Gate for 2. storage|


|fileName|8.swf|
|DigSensNum|8|
|DigActNum|3|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Level crossing with barrier|
|EDigSens1|Train is in the crossing from right|
|EDigSens2|Train is in the crossing from left|
|EDigSens3|Train coming from right|
|EDigSens4|Train coming from left|
|EDigSens5|Barrier is up (right side)|
|EDigSens6|Barrier is down (right side)|
|EDigSens7|Barrier is up (left side)|
|EDigSens8|Barrier is down (left side)|
|EDigAct1|Let barriers down|
|EDigAct2|Switch the white signal (clear)|
|EDigAct3|Switch the red signal|


|fileName|9.swf|
|DigSensNum|3|
|DigActNum|5|
|AnalogSensNum|0|
|AnalogActNum|0|
|EprgName|Wind generator|
|EDigSens1|Generator produce (not used)|
|EDigSens2|Battery low level|
|EDigSens3|Battery high level|
|EDigAct1|Switch generator to battery|
|EDigAct2|Switch 1. lamp to battery|
|EDigAct3|Switch 2. lamp to battery|
|EDigAct4|Switch 1. lamp to network|
|EDigAct5|Switch 2. lamp to network|

