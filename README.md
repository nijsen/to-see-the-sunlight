<a id="readme-top"></a>

<!-- PROJECT HEADER -->
<div align="center">

  <!-- SHIELDS -->
  [![Contributors][contributors-shield]][contributors-url]
  [![Issues][issues-shield]][issues-url]
  [![Last Commit][lastcommit-shield]][lastcommit-url]

  <br />

  <!-- ADD LOGO HERE -->
  
  # To See The Sunlight
  #### *A 2D roguelike vertical platformer*
 My sprint goal for Sprint 2 was adding and including two new features – Double Jump and Sprinting, and New Level Implementation.
 To See the Sunlight is a modular 2D platformer engineered around a dynamic card-modifier system. The architectural framework relies on dedicated managers to cleanly separate data, user interface elements, and physics-driven mechanics. This clean separation of concerns ensures that gameplay modifiers seamlessly interact with the player states. 


  <!-- DOWNLOAD SHIELD -->
  <a href="https://github.com/tearrabyte/to-see-the-sunlight/releases/latest">
    <img src="https://img.shields.io/badge/⬇_Download-Play_The_Game-2ea44f?style=for-the-badge&logo=unity&logoColor=white"/>
  </a>
  
  *Build coming soon - project currently in development.*
  
</div>

<!-- TABLE OF CONTENTS -->
<br />
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#overview">Overview</a></li>
        <li><a href="#key-features">Key Features</a></li>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#play-the-game-recommended">Play The Game (Recommended)</a></li>
        <li><a href="#for-developers">For Developers</a></li>
      </ul>
    </li>
    <li><a href="#credits">Credits</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## About The Project

<!-- OVERVIEW -->
### Overview

<!-- ADD SCREENSHOTS HERE -->

**To See The Sunlight** is a 2D roguelike platformer in which the player controls a shadow creature through a series of biome-based cavern chambers inspired by New Zealand landscapes in an attempt to reach the surface.

Each room introduces environmental mechanics that challenge player movement, visibility, and survival. Upon room completion, the player selects one of three hidden modifier cards that permanently alter the run. These effects stack over time, creating unique gameplay combinations that require continuous adaptation. 

The journey culminates in the creature's emergence into sunlight.

My sprint goal for Sprint 2 was adding and including two new features – Double Jump and Sprinting, and New Level Implementation.
To See the Sunlight is a modular 2D platformer engineered around a dynamic card-modifier system. The architectural framework relies on dedicated managers to cleanly separate data, user interface elements, and physics-driven mechanics. This clean separation of concerns ensures that gameplay modifiers seamlessly interact with the player states. 

**Developer:** Nijaya Supun Senarath-Dassanayake

**Role:** Collaborative Team Member (Sprints 0–1) → Solo Core Developer (Sprint 2)

<br />

#### Objective
Guide the shadow creature to the surface to experience sunlight for the first time.

<p align="right"><a href="#readme-top">Back to top</a></p>


<!-- KEY FEATURES -->
### Key Features
* **Blind card-based modifier system**  
  Select one of three hidden cards after each room, permanently altering gameplay.
  
* **Persistent run-altering modifiers**  
  Effects stack across rooms, creating unique and unpredictable runs.
  
* **Modular vertical room progression**  
  Rooms scale in difficulty as the player ascends.

* **Biome-specific gameplay mechanics**  
  Visually distinct biomes introduce unique mechanics, affecting player movement and survival.

* **Status effect feedback system**  
  Visual sprite and UI feedback clearly communicate active environmental and modifier effects.
  
* **Basic health system**  
  A minimal health system to emphasise environmental danger and player precision.

* **Time-based performance tracking**  
  Tracks player progression and completion time, encouraging optimisation and replayability through faster and more efficient runs.

* **Integrated UI system**  
  Cohesive UI framework including HUD, menus, and card selection interfaces which clearly present game state, player status, and moments of choice. 
  
* **Custom 2D Visual Assets**  
  Original sprite and environment assets to establish a unique visual identity and create a compelling biome-specific atmosphere.

* **Audio Design**  
  A combination of custom and sourced audio, including sound effects and music, used to strengthen player feedback and amplify the atmosphere of each biome.

* **My Chosen Feature 1 for Sprint 2 from Nijaya - Double Jump and Sprinting:**  
  A combination of using explicit tracking constants (maxJumps = 2) reset dynamically by an environment isGrounded circle overlap check. I added this to significantly  enhance game feel, increase player agency, and introduce structural fluidity to core platforming navigation loops.

* **My Chosen Feature 2 for Sprint 2 from Nijaya - New Level Implementation:**  
  A combination of dedicated trigger zones (OnTriggerEnter2D), cross-scene asset transition handlers, and runtime scene management loops. I added this to transition the codebase from a single test scene into a scalable, multi-stage game sequence.

<p align="right"><a href="#readme-top">Back to top</a></p>


<!-- BUILT WITH -->
### Built With
#### Engine & Core
* [![Unity][unity-shield]][unity-url]

#### Programming Language
* [![C#][csharp-shield]][csharp-url]

#### Development Tools
* [![Visual Studio][visualstudio-shield]][visualstudio-url]

#### Art & Visual Design
* [![Aseprite][aseprite-shield]][aseprite-url]

#### Audio & Composition
* [![Beepbox][beepbox-shield]][beepbox-url]

<p align="right"><a href="#readme-top">Back to top</a></p>


<!-- GETTING STARTED -->
## Getting Started

<!-- PLAY THE GAME -->
### Play The Game (Recommended)
*Build coming soon - project currently in development.*

<p align="right"><a href="#readme-top">Back to top</a></p>

<!-- FOR DEVELOPERS -->
### For Developers

<!-- PREREQUISITES -->
#### Prerequisites
- Unity Hub
- Unity 6000.4.0f1
- Visual Studio

<br />

<!-- INSTALLATION -->
#### Installation
```sh
git clone https://github.com/tearrabyte/to-see-the-sunlight.git
```
1. Open Unity Hub
2. Add project
3. Open with correct Unity version
4. Press play

<p align="right"><a href="#readme-top">Back to top</a></p>

<!-- CREDITS -->
## Credits
*Developed as part of a group academic project.*  

<br />

**Development Team**  
*Scrum Master ∙ Game Designer ∙ Developer*  
- [![@tearrabyte][tearrabyte-shield]][tearrabyte-url]  

*Product Owner ∙ Developer*  
- [![@pomegranatees][pomegranatees-shield]][pomegranatees-url]  

*2D Artist ∙ Game Designer ∙ Developer*  
- [![@dashka-str][dashkastr-shield]][dashkastr-url]  

*Developer*  
- [![@nijsen][nijsen-shield]][nijsen-url]  

<p align="right"><a href="#readme-top">Back to top</a></p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- PROJECT GITHUB SHIELDS-->
[contributors-shield]: https://img.shields.io/github/contributors/tearrabyte/to-see-the-sunlight?style=for-the-badge
[contributors-url]: https://github.com/tearrabyte/to-see-the-sunlight/graphs/contributors

[issues-shield]: https://img.shields.io/github/issues/tearrabyte/to-see-the-sunlight?style=for-the-badge
[issues-url]: https://github.com/tearrabyte/to-see-the-sunlight/issues

[lastcommit-shield]: https://img.shields.io/github/last-commit/tearrabyte/to-see-the-sunlight?style=for-the-badge
[lastcommit-url]: https://github.com/tearrabyte/to-see-the-sunlight/last-commit

<!-- PROJECT BUILT WITH SHIELDS-->
[unity-shield]: https://img.shields.io/badge/Unity-6000.4.0f1-black?style=for-the-badge&logo=unity
[unity-url]: https://unity.com/

[csharp-shield]: https://img.shields.io/badge/C%23-.NET_Standard_2.1-blue?style=for-the-badge
[csharp-url]: https://learn.microsoft.com/en-us/dotnet/csharp/

[visualstudio-shield]: https://img.shields.io/badge/Visual_Studio_2026-v.11619.145-5C2D91?style=for-the-badge
[visualstudio-url]: https://visualstudio.microsoft.com/

[aseprite-shield]: https://img.shields.io/badge/Aseprite-v.1.3.17-7D929E?style=for-the-badge&logo=aseprite&logoColor=white
[aseprite-url]: https://www.aseprite.org/

[beepbox-shield]: https://img.shields.io/badge/BeepBox-v.4.2.2-yellow?style=for-the-badge
[beepbox-url]: https://www.beepbox.co/

<!-- PROJECT CREDITS SHIELDS -->
[tearrabyte-shield]: https://img.shields.io/badge/GitHub-tearrabyte-181717?style=for-the-badge&logo=github
[tearrabyte-url]: https://github.com/tearrabyte

[pomegranatees-shield]: https://img.shields.io/badge/GitHub-Pomegranatees-181717?style=for-the-badge&logo=github
[pomegranatees-url]: https://github.com/Pomegranatees

[dashkastr-shield]: https://img.shields.io/badge/GitHub-dashka--str-181717?style=for-the-badge&logo=github
[dashkastr-url]: https://github.com/dashka-str

[nijsen-shield]: https://img.shields.io/badge/GitHub-nijsen-181717?style=for-the-badge&logo=github
[nijsen-url]: https://github.com/nijsen
