# Features

## Scripts
| Name | Purpose |
|-------------|---------|
| TriggerCollider2D | Listens for OnTrigger2D functions and invokes the corresponding UnityEvent |
| TriggerCollider | Listens for OnTrigger functions and invokes the corresponding UnityEvent |

## Common Use Case Functions

Common use case functions for trigger colliders are included
- LoadSceneAsync(string sceneName)
- DestroyObjectCollidedWith(Collider2D other)
- DestroyObjectCollidedWith(Collider other)

### External Compatibility 

This package has built in support for the [Simple Health Package](https://github.com/Mateo-Jimenez76/Unity-Health-Script).
When the Simple Health Package is present, additional use case functions will be available that go as follows
- DamageObjectCollidedWith(Collider2D, int amount)
- DamageObjectCollidedWith(Collider, int amount)

# How To Use

## Setting up the script

Add a TriggerCollider or TriggerCollider2D component to an object.

>[!NOTE]
> The only difference between TriggerCollider and TriggerCollider2D is what physics functions they listen to, OnTriggerEnter or OnTriggerEnter2D and so on, and the corresponding Collider or Collider2D. Functionality and flexibility are otherwise the same between scripts.

A component of type Collider(2D) is required by the script. If one is not already present, then a BoxCollider(2D) will be added to the object and marked as trigger. (The Collider(2D) that is created by default can be changed in the settings menu of the package found in the "Edit/Project Settings" Menu) \
Once a component of type Collider is added it cannot be removed (if it is the only Collider(2D) on the game object) due to the effect of [RequireComponent(typeof(Collider))](https://docs.unity3d.com/ScriptReference/Collider.html). This is done to prevent the script from breaking as it relies on the precense of a Collider(2D) component.

## Using The Defined Unity Events

Each [UnityEvent<Collider(2D)>](https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Events.UnityEvent.html) in the inspector corresponds with their respective OnTrigger functions.
- OnTriggerEnter(2D)
- OnTriggerStay(2D)
- OnTriggerExit(2D)
There are two ways to pass in data to functions using the UnityEvent<Collider(2D)>, writing the data explicitly in the inspector or having the data be passed in through the OnTrigger calls.

## Using The Common Use Case Functions

In order to use the functions, place the CommonUseCaseFunctions scriptable object found at /SimpleTriggerCollider/Runtime/CommonUseCase in the object field of the Unity Event you wish to use the function in. Than select the corresponding function you wish to use. \
The reason for the use of a scriptable object is to circumvent the limitation that UnityEvents can only call functions from object references and not scripts. You cannot create this scriptable object.
