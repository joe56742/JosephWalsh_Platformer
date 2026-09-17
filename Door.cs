using Godot;
using System;

public partial class Door : Area2D
{
	[Export]
	public string LevelToLoad;
	//public void OnPlayerEntered(Node2D node);
	//{
		//if (node is Player)
		//GetTree().ChangeSceneToFile(LevelToLoad);
	//}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
