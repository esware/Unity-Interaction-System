# Unity-Interaction-System
In this tutorial, I will give information about the interaction system, which is a mechanic that is widely used in independent games.

https://user-images.githubusercontent.com/48649947/218380830-cdd397c0-d44d-488e-9876-d7e8f0f6114c.mp4

Interactable objects have an IIinteractable interface . We have 3 main methods in our IIInteractable Interface.
OnInteract();
pick();
Release();
These methods will be customized by other interactable objects that inherit our interface.

![image](https://user-images.githubusercontent.com/48649947/218382101-14da6a80-fc97-463f-8a46-a4a54f5bd7e2.png)

Our InteractableBase class inherits our interactable interface just as it inherits the monobehaviour class.

![image](https://user-images.githubusercontent.com/48649947/218382278-360d414d-3622-43c7-81ce-0790f3a55ce7.png)

Our Interaction Controller class sends a raycast and checks if the raycast encounters an interactable object

![image](https://user-images.githubusercontent.com/48649947/218382986-d2348ab6-c13e-4ea7-871b-0af924914e35.png)

Our Interaction Data and interaction input Data classes are a scriptable object, they control the data exchange between classes, Interaction data is used to define the methods that the Interactable Base class inherits.

![image](https://user-images.githubusercontent.com/48649947/218382631-cdeb7a94-b8c2-4836-9a83-e908f3513dd1.png)
![image](https://user-images.githubusercontent.com/48649947/218382879-879b03e1-0f4b-400b-a2c3-d54a37bf1470.png)

![image](https://user-images.githubusercontent.com/48649947/218382772-5d09e7c3-6883-4590-b081-f13f847d5ddc.png)


![image](https://user-images.githubusercontent.com/48649947/218381402-c72670a6-2dd7-46d5-b887-1571c981c5b5.png)


![Screenshot 2023-02-13 080845](https://user-images.githubusercontent.com/48649947/218380114-4e55c333-ebd4-4261-999c-2835cb2c2dfb.png)
![Screenshot 2023-02-13 080903](https://user-images.githubusercontent.com/48649947/218380116-36f09a4b-0f95-4c48-a1bd-1b5fe4a8915e.png)
![Screenshot 2023-02-13 080918](https://user-images.githubusercontent.com/48649947/218380121-b6ac1981-43f7-43ec-b423-2f06c07f0597.png)
![image](https://user-images.githubusercontent.com/48649947/218380352-a595a72d-5dfe-4656-ad5f-e52ba95f9353.png)
![image](https://user-images.githubusercontent.com/48649947/218380410-68847103-d8e9-4818-9ff3-73b499996848.png)


