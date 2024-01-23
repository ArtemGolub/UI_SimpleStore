# UI_SimpleStore

## Project Description
This project was made to show one of the solutions to implement logic from existing script named "GameModel". The assignment required us to design an interface screen and two windows in the project according to the layouts and implement logic from GameModel script.

### MainMenu

This is a representation of MVC pattern.
Model is getting all the variables that would need from GameModel and View is showing them to the player.
In that case Controller has additional logic for subscription to UnityEvents named OnConvertCoinToCredit and OnBuy.


### CurrencyChanger
This is a representation of MVC pattern.
In that case we have simmilar logic as in MainMenu.
Model is getting all nessecary variables from GameModel, also handle player Input in InputField to calculate CurrencyChange.
Controller has additional subscription for UnityEvent named OnConvertCoinToCredit

### Store
This is a representation of MVC pattern.
The main logic was to create ItemBar that can handle all the data for Items.
We have Scriptable Item that contains fields for ConsumableTypes, Name, Description etc.
The model contains logic for Buy and Getting price base on ConsumableTypes.
And the view is updating its inGame visual.
This logic was implemented to simplify adding additional Items to the store.

### GameController
Based on name of existing script (GameModel) i suggested that was a part of some MVC system.
So instead of implementing "Update" in any Monobehaviour script i made a GameController that handles additional logic for UnityEvents that Invokes on operationComplete logic.

### OnConvertCoinToCredit and OnBuy Events
Basicly this events was made to handle Currency update in different Canvases.
I wanted to implement logic that can exist one without another.
So the Store and ItemBars might work without CurrencyChanger and CurrencyChanger without ItemBars. 