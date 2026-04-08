HOW TO REPLACE UI MUSIC IN FALCON BMS

1. Download the music as .ogg format: https://drive.google.com/file/d/1OW4p-LlVjlZiPcIkFOcvGA86tiLNg_rU/view?usp=sharing
2. Make a backup of your folder X:\Falcon BMS 4.36\Data\Music
3. Paste the music in X:\Falcon BMS 4.36\Data\Music
4. Open this file (with Notepad++, etc.): C:\Falcon BMS 4.35\Data\Art\Main\soundrc.irc
5. Search for line 187-196
6. Edit the music data names, for example: 

-----OLD-----
[STREAMSOUND] SND_AMBIENT1        "music\ui1.ogg"     S_BIT_NORMAL S_BIT_FADE_OUT S_BIT_LOOP
[LOOPCOUNT]   SND_AMBIENT1 1

-----NEW-----
[STREAMSOUND] SND_AMBIENT1        "music\1-The Falcon.ogg"     S_BIT_NORMAL S_BIT_FADE_OUT S_BIT_LOOP
[LOOPCOUNT]   SND_AMBIENT1 1

7. Save
8. Enjoy

Cheers
Micro

