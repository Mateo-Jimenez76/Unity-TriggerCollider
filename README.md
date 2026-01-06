# Simple Trigger Colliders



# Features
This package has built in support for the [Simple Health Package](https://github.com/Mateo-Jimenez76/Unity-Health-Script).
This support adds the ability to deal damage to an object with the Health component when they enter/stay/leave a trigger collider. 



# How To Use
Add TriggerCollider or TriggerCollider2D respectively component to an object.

>[!NOTE]
> For the rest of the readme, for convenience sake, I will only refer to the 3D version of the script and any relating components.
> But note that the only difference between TriggerCollider and TriggerCollider2D is what physics functions they listen to, OnTriggerEnter or OnTriggerEnter2D and so on, and the corresponding Collider or Collider2D.
> Functionality and flexibility are otherwise the same between scripts.

A component of type Collider is required by the script. If one is not already present, then a BoxCollider will be created. (The Collider that is created by default can be changed in the settings menu of the package found in the "Edit/Project Settings" Menu)
