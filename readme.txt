Dicepool C# Library

This library will allow the creating and rolling dicepools. A dicepool being set of dice rolled together for a particular resolution in a tabletop game.
It is designed to support more unconventional resolution mechanics like the icon based dice pool from FFG's Star Wars RPG or the exploding dice from Savage Worlds

Important: This library is in early alfa state, the design of the public methods can change without warning.

How to use

The library is used by creating a Dicepool object and filling it with Die objects. the Dicepool can then be rolled using the roll() method as often as needed.
Die objects are created directly or by using a Dicepool's addDie() method. Dice can either be numbered from 1 to n or have the content of every side specified.
Both Dicepools and Dice can have behaviors like exploding dice or rerolling results set. The behaviours of dice overrule those of the dicepool.

Dicepool Class
Properties

private List<Die> dicepool: List of Die objects that will be rolled by the roll() method
private List<Dictionary<string, string>> results: List of previously rolled results. The newest result is added at the end of the List. The name of the Die is linked to the rolled result

Methods

public List<Die> getDicepool()
public List<Dictionary<string, string>> getResultsHistory()
public Dictionary<string, string> getLastResult()

public void addDie(Die die): add a copy off the Die object to the dicepool List 
public void addDie(int n, String name = ""): add a die with n facets numbered from 1 to n to the dicepool List
public void addDie(string[] values, String name = ""): add a die to the dicepool List with the same values as the array

public Dictionary<string, string> roll(): executes the roll() method of each Die in the dice list and returns the results

Die class
Properties

private string name: the name of the die
private string[] facets: the list of possible results of rolling the die

Methods

public string getName()
public string[] getFacets()
public string roll()

RollRules interface
Properties

private bool explode: sets whether the die explodes upon rolling a specific result
private string[] explodingResults: if the die rolls any of these results while the explode property is true it will be rolled again and the result added. A numeric die with an empty explodingResults will reroll upon rolling the highest result
private bool reroll: sets whether the die rerolls upon rolling a specific result
private string[] rerollingResults: if the die rolls any of these results while the reroll property is true it will be rolled again and the result replaced. A numeric die with an empty rerollingResults will reroll upon rolling the lowest result

Methods:
public Dictionary<string, bool> getRules()
public void setExplode(bool enable, string[] explodingValues = [])
public string[] getExplode()
public void setReroll(bool enable, string[] explodingValues = [])
public string[] getReroll()