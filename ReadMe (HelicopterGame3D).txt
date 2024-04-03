HelicopterGame3D

SETUP INSTRUCTIONS:
MUST use Unity version 2018.4.28f1 for this project (newer versions are not compatible)
With Unity opened, in the lower left window, go to the Assets/ProtoPack/Resources/Models folder
You must INDIVIDUALLY Reimport 'airplane', 'lameheli' (there are two), and 'skyscrapers'
-> Selecting 'Reimport all' does NOT correctly reimport theses models!

TO RUN:
In the center viewer tab, select 'Game' and press the arrow key
-> or, to play normally via build:
Select Ctrl-B to build and run (I'm currently using the Temp folder that I created)

TO RUN AFTER MAKING CHANGES WITHIN VISUAL STUDIO:
It appears that Unity automatically recompiles providing you've saved your changes in Visual Studio
Thus, within the "Game" screen, press the start arrow to run your program after making changes.

---------------------------------------------------------------------------------------------------------------------------


NEXT STEP(S):
1)  Figure out how to get code to run/play using Unity
Continue watching lecture while concurrently notating code
2)  Create flowchart of code
3)   >>>>>>>>>>>>> ARE PUBLIC VARIABLES VISIBLE TO OTHER CLASSES (eg. scrollSpeed?)
4)  >>>>>>>> HELICONTROLLER.CS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! <<<<<<<<<< THIS!!!!!!!!!!!!!!!!!!!!
5) It's scrollingSpeed that must be reset: NOT speed!

***** NOTE THAT YOU HAVE BOTH A "speed" and "scrollSpeed" VARIABLES!!!!!!!!!!!!!!!!!!!!!

To resolve increasing speed
ScrollingBackground.cs?
-> reset Time.time?

Look within either:
Scrolling Backgrounds.cs
Bounds.cs
SKYSCRAPER.CS   <<<<<<<<<<<<<<<<<<<<
GAMEOVERTEXT.CS ---reset speed here??????????????????

Time.time represents the time the game begins (from ScrollingBackground.cs)

Lecture currently paused at:
-Lecture completed-

