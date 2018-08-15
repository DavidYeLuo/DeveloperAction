Developer Action game

Symbols | Definitions
[] -> Not started.
[-] -> Started.
[x] -> Finished.

Ideas:
 -Like a rpg where the player is a genius developer
 -The player is able to code under a workbench
 -Level design to place objects easier


TODO:
 [-] Player movement. (8/10/2018)
 [x] Camera movement input. (8/10/2018)
 [x] Create a level editor (8/10/2018)
 [] Create a workbench
	[] Have a UI
		[] Edit weapons
		[] Edit codes 
			[POSSIBLE CONCERN]: 1) Overwhelmingly Complicated 
								2) Easily gamebreaking mechanic 
								3) Lots of coding 
								4) Lots of testing
 [] Main Menu
	[] Save/Load
 [] Sound
 [] Model
	[] Animation

 Coding
 --------------------------------------------------------------------------------------------------------------------------------
[-]Player movement
	[x]The keys 'W' and 'S' changes Z-axis values of the player's position and the keys 'A' and 'D' changes the X-axis. (8/10/2018)
	[]Player movement by changing transform makes physic mechanics clunky. (8/12/2018)
		[] Use forces from rigid body instead. (8/12/2018)
[x]Player Mouse movement.
	[x](I feel like) Intuitively and naively the change in xy-coordinate. (8/10/2018)
	[x]From a youtube, I shouldn't change the transform.rotation directly. (8/10/2018)
	[x]Figure out how to not have the character tilt uncontrollably. A possible solution might be locking the z-axis?) (8/10/2018)
	[x]Concern about player movements: So far the player movement depends on which way the character is facing. (8/10/2018)
		* Possible solution is to merge the CameraMovements class with PlayerMovements class. (8/12/2018)
		* *Chosen* Another possible solution is to keep the CameraMovements class but use public methods so that PlayerMovement uses it. (8/12/2018)
[-]Player KeyPresses:
	[-]Find a way to regrab the user's focus after pressing 'esc'. (8/10/2018)

[x]Level editor (8/12/2018)
	[x]Watch brackey's video to learn about it. (8/12/2018) https://www.youtube.com/watch?v=B_Xp9pt8nRY
--------------------------------------------------------------------------------------------------------------------------------
