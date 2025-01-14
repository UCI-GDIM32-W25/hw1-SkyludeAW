[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1

## W1L2 In-Class Activity
How would you describe this game world in objects
	The game world consist of these objects:
	UI
	Player
	Plant
	Background
	Camera

What attributes and actions do these objects have?
	UI
		Displaying how many seeds are planted/remains
	Player
		Movement: up/w,down/s,left/a,right/d
		Space: Planting the seed
	Plant
		Stays on spot and demonstrates its existence in the rapidly-adapting game world of unity. Wondering the meaning of it�s own life, perhaps the only reason for it to exist is to entertain the watchers of the beyond.

How do these objects act on or affect each other?
	The player�s current position affects where the seed is planted
	The number of seed objects in the scene affects what is displayed on the UI


## Devlog
This project is simple and consists of only the Player and UI as the main objects.
I began by adding code for the Player, where I used Input.GetAxis() * _speed * Time.deltaTime for the movements and Input.GetKeyDown() to call PlantSeed(), which instantiates a Plant prefab on the _playerTransform's current position. 
PlantSeed() also calls _plantCountUI's UpdateSeeds() with the new # of seeds remaining and planted, and updates the text on the UI.
As for the Plant, they does nothing after being instantiated, so I figured to at least give them a small non-looping animation after they spawn/entry.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
