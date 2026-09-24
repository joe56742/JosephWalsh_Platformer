using Godot;
using System;

public partial class DeathPlane : Area2D
{
	[Signal]
	public delegate void HitEventHandler();

	private void Death()
	{
		EmitSignal(nameof(HitEventHandler));
		QueueFree();
	}

	private void OnPlayerEntered(Node2D player)
	{
		Death();
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
