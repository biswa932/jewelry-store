# jewelry-store
Win Forms application for a tiny jewelry store
IDE used: Visual Studio 2019
OS: Windows 10
.Net Framework 4.7.2

Details:
User data is feteched from a xml file with the following format:

location: JewelryStore\JewelryStore\bin\Debug\UserData.xml
Content:
<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<root>
    <Regular>
        <Username value="abc" />
        <Password value="abc" />
    </Regular>
    <Privileged>
        <Username value="def" />
        <Password value="def" />
    </Privileged>
</root>

Output is also printed to the file JewelryStore\JewelryStore\bin\Debug\TotalGoldPrice.txt when user clicks
on "Print to File" button.

To start the application:
You can run the code directly by clicking "Start" from Visual Studio 
or directly from the .exe file: JewelryStore\JewelryStore\bin\Debug\JewelryStore.exe

Login credentials:
Regular user:
Username: abc
Password: abc

Privileged user:
Username: def
Password: def
