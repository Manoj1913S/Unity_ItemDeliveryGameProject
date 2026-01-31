# Unity_ItemDeliveryGameProject
This is a Simple 2D item delivery dash game which is made inside Unity

#  Simple 2D Item Delivery Game (Unity)

This is my **first simple 2D delivery game project** made in Unity. I created this project to practice basic game development concepts like movement, collision, trigger, particles, and UI text.

I am a beginner in Unity, so this project is simple and easy to understand.

---
##  Game Concept

In this game, the player controls a delivery car.

The main goal is:

* Pick up a package
* Deliver it to the customer
* Use booster to increase speed
* Avoid obstacles to keep normal speed

The car can carry only one item at a time.

---

##  Characters / Objects

 Delivery Car – Player controlled vehicle
 Package Item – Item to pick up
  Customer – Receives the delivery
 Booster – Gives speed boost
 Obstacle / Environment Object – Reduces speed

---

##  Game Mechanics

###  Item Pickup System

* Player picks up the package using trigger collider
* Only one package can be carried at a time
* Particle effect plays when item is picked
* Item gets destroyed after pickup

###  Delivery System

* When player touches customer with package
* Package is delivered
* Particle effect stops
* Player can pick next package

###  Booster System

* When car touches booster:

  * Speed increases
  * Boost text UI becomes visible
* Booster object is destroyed after use

###  Collision Speed Reset

* When car collides with environment object:

  * Speed returns to normal
  * Boost text UI is hidden

---

##  Controls

| Key | Action        |
| --- | ------------- |
| W   | Move Forward  |
| S   | Move Backward |
| A   | Rotate Left   |
| D   | Rotate Right  |

---

## 🛠 Scripts Used

###  Delivery.cs

This script handles:

* Package pickup
* Delivery detection
* Particle system play and stop
* Item destroy with delay

Features:

* Uses `OnTriggerEnter2D`
* Uses Tags (Package, Customer)
* Controls particle effects

---

###  Controller.cs

This script controls the car movement and booster system.

Features:

* Keyboard input movement
* Rotation control
* Speed boost system
* Collision speed reset
* UI text enable and disable

Uses:

* New Input System
* Rigidbody movement
* Trigger and collision detection

---

##  What I Learned From This Project

From this project I learned:

* Transform movement
* Rotation system
* SerializeField usage
* Keyboard input handling
* Rigidbody2D basics
* Collider and Trigger
* Particle System
* Prefab usage
* Tag system
* UI Text (TMP)
* Physics collision
* Simple game logic

---

##  Tools Used

* Unity Engine
* C# Programming Language
* TextMeshPro (TMP)
* Unity Input System

---

##  How To Run This Project

1. Download or clone this repository
2. Open Unity Hub
3. Click "Open Project"
4. Select this project folder
5. Press Play button in Unity

---

##  Final Note

This is my **learning project**. I made it to improve my Unity and game development skills.

If you are also a beginner, this project can help you understand:

* Basic movement
* Trigger system
* Delivery logic
* Speed boost system

Thank you for checking my project 
