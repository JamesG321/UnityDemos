# UnityDemos

This repository is a collection of various demo projects for Unity that I made, aimed to be easy-to-understand examples of various functionalites in Unity, with scripts that can be taken and used off-the-shelf. All projects' interactive demos can be found on my unity connect profile, under the 'games' tab: [my Unity connect profile](https://connect.unity.com/u/james-guo)

All projects are made under Unity 2018.4.

## Click and drag demo
![Click and drag thumbnail](https://github.com/JamesG321/UnityDemos/blob/master/Images%20for%20documents/click%20and%20drag%20thumbnail.png)
This is a demo for a click and drag script that allows the user to pick up and move/drag around an object using thier mouse. Release velocity is also calculated based on how fast the user drags the object before letting go of the click. This allows the user to 'throw' around the object as well. 

To use it in your own project, simply attach [DragObject.cs](https://github.com/JamesG321/UnityDemos/blob/master/Click%20and%20drag%20demo/Assets/Scripts/DragObject.cs) to a rigid body.

Interactive webGL demo: [click and drag webGL demo](https://connect.unity.com/p/click-and-drag-script-demo)

### Models used: [Farm Animals Set by Vertex Cat](https://assetstore.unity.com/packages/3d/farm-animals-set-97945)

## Day night cycle script
![Day night cycle tumbnail](https://github.com/JamesG321/UnityDemos/blob/master/Images%20for%20documents/DayNightCycle%20thumbnail.png)
This demo is a simple day night cycle system using a diretional light and achieveing the effect of sunlight changing throughout the day by changing the intensity and rotation of the light. 

Complete with adjustable day length and time of day.
![Day night cycle Variables](https://github.com/JamesG321/UnityDemos/blob/master/Images%20for%20documents/DayNightCycle%20inspector%20variables.PNG)

To use it in your own project, attach [SetSunlight.cs](https://github.com/JamesG321/UnityDemos/blob/master/DayNightCycle/Assets/Scripts/SetSunlight.cs) to your project and add a directional light as the sun into the public variable.

### Models used: 

#### Tent and campfire: [LowPolySurvivalEssentials demo by BrokenVector](https://brokenvector.itch.io/ultimate-low-poly-survival)
#### Low poly tree: [Low poly tree by kotzuo](https://sketchfab.com/3d-models/low-poly-tree-6d986e0b24b54d85a5354e5cac6207a1)
#### Moon texture: [solarSystemscope.com](https://www.solarsystemscope.com/textures/)


