Feature: Game

Scenario: Gutter Game
	Given a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	And a roll knocks 0 pins over
	When the game is over
	Then the score should be 0
	
Scenario: Sporadic Game
	Given a roll knocks 3 pins over
	And a roll knocks 5 pins over
	And a roll knocks 7 pins over
	And a roll knocks 3 pins over
	And a roll knocks 1 pins over
	And a roll knocks 0 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 5 pins over
	And a roll knocks 2 pins over
	And a roll knocks 8 pins over
	And a roll knocks 2 pins over
	And a roll knocks 8 pins over
	And a roll knocks 0 pins over
	And a roll knocks 5 pins over
	And a roll knocks 5 pins over
	And a roll knocks 6 pins over
	And a roll knocks 4 pins over
	And a roll knocks 7 pins over
	When the game is over
	Then the score should be 128
	
Scenario: Perfect Game
	Given a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	And a roll knocks 10 pins over
	When the game is over
	Then the score should be 300