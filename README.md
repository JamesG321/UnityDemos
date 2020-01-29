# UnityDemos

This repository is a collection of various demo projects for Unity that I made, aimed to be easy-to-understand examples of various functionalites in Unity, with scripts that can be taken and used off-the-shelf. All projects' interactive demos can be found on my unity connect profile, under the 'games' tab: [my Unity connect profile](https://connect.unity.com/u/james-guo)

All projects are made under Unity 2018.4.

## Click and drag demo
![Click and drag thumbnail](https://github.com/JamesG321/UnityDemos/blob/master/Images%20for%20documents/click%20and%20drag%20thumbnail.png)
This is a demo for a click and drag script that allows the user to pick up and move/drag around an object using thier mouse. Release velocity is also calculated based on how fast the user drags the object before letting go of the click. This allows the user to 'throw' around the object as well. 

To use it in your own project, simply attach [DragObject.cs](https://github.com/JamesG321/UnityDemos/blob/master/Click%20and%20drag%20demo/Assets/Scripts/DragObject.cs) to a rigid body.

### Interactive webGL demo: [Click and drag webGL demo](https://connect.unity.com/p/click-and-drag-script-demo)

### Models used: [Farm Animals Set by Vertex Cat](https://assetstore.unity.com/packages/3d/farm-animals-set-97945)

## Day night cycle script
![Day night cycle tumbnail](https://github.com/JamesG321/UnityDemos/blob/master/Images%20for%20documents/DayNightCycle%20thumbnail.png)
This demo is a simple day night cycle system using a diretional light and achieveing the effect of sunlight changing throughout the day by changing the intensity and rotation of the light. 

Complete with adjustable day length and time of day:
![Day night cycle Variables](https://github.com/JamesG321/UnityDemos/blob/master/Images%20for%20documents/DayNightCycle%20inspector%20variables.PNG)

To use it in your own project, attach [SetSunlight.cs](https://github.com/JamesG321/UnityDemos/blob/master/DayNightCycle/Assets/Scripts/SetSunlight.cs) to your project and add a directional light as the sun into the public variable.

### Interactive webGL demo: [Day night cycle demo](https://connect.unity.com/p/day-night-cycle-demo)

### Models used: 

#### Tent and campfire: [LowPolySurvivalEssentials demo by BrokenVector](https://brokenvector.itch.io/ultimate-low-poly-survival)
#### Low poly tree: [Low poly tree by kotzuo](https://sketchfab.com/3d-models/low-poly-tree-6d986e0b24b54d85a5354e5cac6207a1)
#### Moon texture: [solarSystemscope.com](https://www.solarsystemscope.com/textures/)

## Rigidbody toaster demo
![Rigidbody toaster thumbnail](https://github.com/JamesG321/UnityDemos/blob/master/Images%20for%20documents/toaster%20thumbnail.PNG)
This demo shows the usage of rigid body physics and box colliders with a toaster that ejects toast at high speed and bounces around a confined space colliding with the walls and toast. Complete with adjustable eject force and toast spawn points: ![toaster variables](https://github.com/JamesG321/UnityDemos/blob/master/Images%20for%20documents/rigidbody%20toaster%20inspector%20variables.PNG)

The demo was built to be a prototype/proof of concept segment for the [codavore](https://codavore.blogspot.com/) game, where the toaster is the first malfunction that the player would experince in their spaceship.

### Interactive webGL demo: [Rigidbody toaster demo](https://connect.unity.com/p/rigidbody-toaster-demo)
Controls: Space - eject toast on both sides, G & H - eject toast on left/right side, C - switch between overview/toaster cam, R - reset

### Models used: [toaster by idealton, remixed and sperated by me](https://sketchfab.com/3d-models/toaster-888f15c535bd4eeea3934e235370941d)


