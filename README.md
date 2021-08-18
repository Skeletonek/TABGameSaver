# TABGameSaver
Application used to backup saves of the They Are Billions game in Survival mode.

Imagine this: You are playing a survival mode in They Are Billions you are doing pretty great but you didn't predict that the next zombie horde
will be so large, so you lose. And because you lost, the game deletes your entire save! But this was your greatest run!

Fear not! TAB Game Saver is here for you! This program copies your saves to other folder, so if TAB will delete your save file due to losing game,
TAB Game Saver will restore your save!

**Backup of your saves is done after you "exit & save" to main menu**

## How to run
### Requirements
 - Microsoft Windows x86 or x86-64: XP w/ SP3, Vista w/ SP1, 7 or later
 - Apple MacOS: 10.8 - 10.14 through WINE 
 - Linux x86 or x86-64 through WINE
 - .NET Framework 4 minimum installed (WINE: Install through Winetricks)

> I'll try to port TABGameSaver natively to Linux and MacOS

### Running (Windows)
Firstly download the latest release from [here](https://github.com/Skeletonek/TABGameSaver/releases). Put the executable in TAB game save directory.

This should be in your **user documents folder, then My Games/They Are Billions/Saves**.

e.g. Windows 7:
`C:\Users\<UserName>\Documents\My Games\They Are Billions\Saves`

Run the app from there and that's it! Now every time when you come back to main menu after playing survival, TAB will save your progress and 
TAB Game Saver will backup this save, and recover it if you will lose your settlement in game!

### Running (WINE)
Firstly you need to have WINE installed. As you are trying to play Windows game on other OS i assume you have it already installed.
For your convience you should have [Winetricks](https://wiki.winehq.org/Winetricks) installed too. You can install them from your package manager.

e.g. Debian / Ubuntu
```
sudo apt update
sudo apt install winetricks
```
Next, run winetricks, choose your default prefix, and choose to install windows dll or component. Find and install dotnet40.
You can also do it by command:
`winetricks dotnet40`

At last, put executable in your WINE prefix folder. Full path should look something like this:
`/home/<UserName>/.wine/drive_c/users/<UserName>/Documents/My Games/They Are Billions/Saves` 

**Make sure to check "Show hidden files" in your file manager!**

*If ".wine" folder does not exist, just launch some .exe (e.g. TheyAreBillions.exe!), wine will automaticly create it.*

Run program through WINE, and that's it! Now you can die infinite times in survival mode in TAB!

## Supported languages (as for now)
 - en-US *(default)*
 - pl-PL
