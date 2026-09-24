using Godot;
using System;

public partial class Door : Area2D
{
	object node;
	[Export] public string LevelToLoad;
	private void OnPlayerEntered(Node2D node)
	{
		
		if (node is CharacterBody2D) ;
		{
			GetTree().ChangeSceneToFile(LevelToLoad);
		}
	}



	//Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
