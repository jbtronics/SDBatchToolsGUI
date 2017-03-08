# SDBatchToolsGUI
A Gui for the Substance [Designer Batch Tools] (https://support.allegorithmic.com/documentation/display/SB10/Substance+Batchtools+User%27s+Guide) .


## Features
* GUI for the most functions of the Tools
* Filechooser with the system dialogs
* Invalid options are greyed out
* Export Tool output to text file
* Export Command line to batch file
* Feature to open Output folder of the tool
* "Builder" tool for creating sbsrender output names.
* Header with start date and cmd line are added before output (you can disable this in the settings)

## Usage
Download Release.zip from Releases Tab and unpack it. Start the SDBatchToolsGUI.exe .

If you want the tool installed on you system (with start menu entry etc.), then download Setup.zip, unpack and run setup.exe. This will download all dependencys (.NET 4.6) if not installed on your system and install the tool.

## Troubleshoot
If you get a message like "The system cannot get the file specified at...", then you have to set the option "Path to BatchTools" under Settings, so that it points to the folder, where the .exe files of the Batch Tools are.

## Screenshots

![alt text](https://github.com/do9jhb/SDBatchToolsGUI/raw/master/img/sbsbaker.png "sbsbaker")
![alt text](https://github.com/do9jhb/SDBatchToolsGUI/raw/master/img/sbscooker.png "Name Builder")
![alt text](https://github.com/do9jhb/SDBatchToolsGUI/raw/master/img/sbsmutator.png "Name Builder")
![alt text](https://github.com/do9jhb/SDBatchToolsGUI/raw/master/img/sbsrender.png "Name Builder")
![alt text](https://github.com/do9jhb/SDBatchToolsGUI/raw/master/img/name_builder.png "Name Builder")
![alt text](https://github.com/do9jhb/SDBatchToolsGUI/raw/master/img/output.png "Name Builder")

## Issues
If you have any problems, issues or have ideas how to improve this tool, then open an Issue in the Issues tab.
