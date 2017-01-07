# Rendering a Minecraft World in Unity3d #

A playground for testing WorldStream.

### Getting Started ###

You must be running the free edition of Unity v5.5. There is a lot of incompatabilities between different versions and editions of Unity. Clone and open the project in Unity. Running the game, you should see this:

![](http://i.imgur.com/xNxVSee.png)

These were generated from [`Assets/Resources/World.json`](Assets/Resources/World.json).

Look at the Project tab, and navigate to [`Assets/Resources/Blocks/Models`](Assets/Resources/Blocks/Models), where you can browse the prefabs for each and every block. When running the [`GenerateBlocks`](Assets/Scripts/GenerateBlocks.cs) script, the blocks are loaded from here. [Each block is named after it's Minecraft ID](http://minecraft-ids.grahamedgecombe.com).

![](http://i.imgur.com/MZQuCBJ.png)

Open up the [`World.json`](Assets/Resources/World.json), and experiment by editing or adding blocks with different `type` and `position` values. You'll need to re-run the game to see your changes.

### What's next? ###

We are still missing some prefabs for some blocks, like fences and doors and stairs. Consult the [Issues](https://github.com/ehgoodenough/unity-minecraft-renderer/issues).

And after that, we make a game. :D
