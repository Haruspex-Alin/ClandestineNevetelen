using Godot;
using System;

public partial class MainMenu : Control
{

	public Node startScene; //node to just track our start scene to change to after pressing "START"
	[Export]
	public string StartScenePath = "res://Example World/Objects/World/world.tscn";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		startScene = ResourceLoader.Load<PackedScene>(StartScenePath).Instantiate(); //loads the start scene so we can later move to it
	}

	public void _on_start_button_down()
	{
		GetTree().Root.AddChild(startScene); //scene is now added to the "ingame" tree. now we need to remove the previous one to change it
		GetNode("/root/MainMenu").QueueFree(); //removing the previous scene
	}
}
