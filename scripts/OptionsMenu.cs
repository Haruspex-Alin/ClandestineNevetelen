using Godot;
using System;

public partial class OptionsMenu : Control
{

	public Node mainMenuScene; //node to just track our start scene to change to after pressing "BACK"
	[Export]
	public string mainMenuScenePath = "res://scenes/mainmenu.tscn";

	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		mainMenuScene = ResourceLoader.Load<PackedScene>(mainMenuScenePath).Instantiate(); //loads the main menu scene so we can later move to it
	}

	public void _on_back_button_down()
	{
		GetTree().Root.AddChild(mainMenuScene); //scene is now added to the "ingame" tree. now we need to remove the previous one to change it
		GetNode("/root/OptionsMenu").QueueFree(); //removing the previous scene
	}
}
