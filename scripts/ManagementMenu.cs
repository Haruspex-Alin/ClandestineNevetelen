using Godot;
using System;

public partial class ManagementMenu : Control
{

	public Node mainMenuScene; //node to just track our start scene to change to after pressing "BACK"
	[Export]
	public string mainMenuScenePath = "res://scenes/mainmenu.tscn";

	public Node missionScene; //node to just track our start scene to change to after pressing "BACK"
	[Export]
	public string missionScenePath = "res://scenes/mission1.tscn";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		mainMenuScene = ResourceLoader.Load<PackedScene>(mainMenuScenePath).Instantiate(); //loads the main menu scene so we can later move to it
		missionScene = ResourceLoader.Load<PackedScene>(missionScenePath).Instantiate();
	}

	public void _on_back_button_down()
	{
		GetTree().Root.AddChild(mainMenuScene); //scene is now added to the "ingame" tree. now we need to remove the previous one to change it
		GetNode("/root/ManagementMenu").QueueFree(); //removing the previous scene
	}

	public void _on_start_mission_button_down()
	{
		GetTree().Root.AddChild(missionScene); //scene is now added to the "ingame" tree. now we need to remove the previous one to change it
		GetNode("/root/ManagementMenu").QueueFree(); //removing the previous scene
	}
	
}
