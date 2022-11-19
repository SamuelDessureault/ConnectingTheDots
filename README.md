# ConnectingTheDots

## Description
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This project is a demo build of a minigame where you place clues, represented by cards, onto a board and attach them to each other with a rope. Every clue is either related or contradicts eachother and it is the player's job to connect everything together with the ropes and solve the mystery! If 2 clues are related to eachother (ex. an apple and an orange are both fruits), the rope connecting them will turn green. If they contradict eachother (ex. an apple is a fruit and a carrot is a vegetable), the rope will turn red. However, if they have nothing to do with eachother (ex. an apple and a car), the rope will disappear and the player will lose health.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;I have created this project in order to implement in a much bigger game I am working on with a friend. The idea is to make the characters gather all their current clues and piece together how they all fit, including if they don't fit at all. The player will gain access to more experience points and, in some cases, new quests depending on their performance.

## Controls (**Debug Controls)
- Move the clues:
  - Drag the clue with the mouse.
- Move the ropes:
  - You can only drag one end of the rope at a time with the mouse.
- Create a rope:
  - Press Q.
- **Manually lose health
  - Press the space bar
  
## Current Issues/Bugs:
- Ropes are created out of bounds. (Fixed)
