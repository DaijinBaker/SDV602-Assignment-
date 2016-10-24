//Allows access to the classes of these systems, to be used in the script
using System;

	[Serializable]
	public class Player //creating a class called Player
	{
		// Class
		private static int _player_number = 0; //creating a static variable and setting it to 0
		
		// Instance
	    private int _number = (Player._player_number++); //taking the _player_number static variable and adding 1 
	    private string _name; //creating a private variable of the type string
	    private Item[] _inventory;    //creating a array this will contain all of the items in the inventory.
	    private Scene _currentScene; //create a private variable using type scene
	   
		public Scene CurrentScene //encapsulating the current scene field
		{ 
			get{
				return _currentScene;
			} 
			set{
				_currentScene = value;
			}
		}
		public String Name //encapsulating the name field
		{ 
			get{
				return _name;
			} 
			set{
				_name = value;
			}
		}
		private void AddScore(){ //creating a function
			Persist.control.Score = Persist.control.Score + 10; //creating an instance of the Persist class, getting the score and adding 10.
		}
		public void Move(GameModel.DIRECTION pDirection){ //creating method called move
			
		switch(pDirection){ //check direction value that has been set in the gamemodel
				case GameModel.DIRECTION.North: //if the direction north is inputted the code below will activate
					 
						if( _currentScene.North != null) //check if there is a scene north of the current scene
						{
							_currentScene =  _currentScene.North; //make scene the current scene
							AddScore(); //calling add score method
						}
						break;
		case GameModel.DIRECTION.South: //if the direction south is inputted the code below will activate
			if( _currentScene.South != null) //check if there is a scene south of the current scene
			{
				_currentScene =  _currentScene.South; //if there is a scene south then make this the current scene to display
				AddScore(); //calling add score method
			}
			break; //end of case statement
		case GameModel.DIRECTION.East: //if the direction east is inputted the code below activates
			if( _currentScene.East != null) //check if there is a scene east of the current scene
			{
				_currentScene =  _currentScene.East; //displays as current scene
			}
			break; //end of case statement 
		case GameModel.DIRECTION.West: //if the direction west is inputted the code below activates
			if( _currentScene.West != null) //check if there is a scene west of the current scene
			{
				_currentScene =  _currentScene.West; //displays as current scene
			}
			break; //end of case statement
			}
		}

		public void InitialisePlayerState(){ 
			if(Persist.control != null){
				Persist.control.Score = 0;
				Persist.control.Health = 100;
			}
		}
		public Player ()
		{
			//InitialisePlayerState();
		}
	}


