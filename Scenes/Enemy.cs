using Godot;
using System;

public partial class Enemy : CharacterBody2D
{
	public const float Speed = 100.0f;
	

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;
		bool facingRight = true;
		
		if (facingRight)
		{
			velocity.X = 1 * Speed;
		}

		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");



			velocity.X = direction.X * Speed;
	
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		

		Velocity = velocity;
		MoveAndSlide();
	}
}
