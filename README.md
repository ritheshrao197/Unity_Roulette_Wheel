Roulette Wheel

6th June 2021
By Rithesh 

Click here for Git link
Click here for Drive link.

OVERVIEW
3d Roulette Wheel Implementation using Unity.Player needs to select the number before spinning the Roulette Wheel. 0 to 36 and a button which when clicked would start rotating the wheel like a roulette.The ball would start moving from the outer end and slowly find its way into the inner slot next to the number which was picked. 
GOALS
Game Screen: - Roulette Wheel with 36 numbers and UI dropdown .Users need to select the number and spin the wheel.
Game Rules: - When the user clicks the Spin button Wheel and ball starts rotating and ball needs to stop next to the number picked by the user.

SPECIFICATIONS 
Made a Roulette Wheel and ball using Unity 3d basic shapes and assigned the materials to it .
Created Wheel controller ,which will rotate and stop the wheel based on the conditions.
Created Ball controller ,which will rotate the ball around the center pivot ,and  moves the ball on low speed ,then stops the ball near the number selected by the user..
Used Unity actions in Game manager to  control the Ball and Wheel.
Rotation,Acceleration and position of Wheel and Ball are controlled using Lerp function.

Limitations/to be Implemented:

Realistic 3D view is not implemented.
The Roulette Wheel image does not have the equal gap between the numbers which makes the ball stop with some offset angle/position.
Displaying the ball stoped number is not Implemented
Level complete or Reset is not handled.Scene is reloaded on Reset button click.
Unity physics features are not used.
Animations are not used for rotation of the wheel.
