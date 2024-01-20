# Requirement
- BepInEx is required
- Definitely not compatible with other game
- Tested only in 2.0.55 Steam version (Public Beta)
- If there is a conflict after update for config, then delete the config

# AeroFortaMoreHangar Plugin
This plugin will add/set the amount of hangar bay for Magnus and Overlord(and any of their variant)
- Customizable for each ship.
- Allowing to set what MaxShipType that allowed to dock.


  
# Currently Known Issue(Must Read!!):
- Any saved file with this plugin modification will cause that save to be unloadable when you trying to load the game without this plugin or trying to load the save file with different amount of hangar bay because you change something in the config.
- Global multiplier so you don't need to individually adjust everything?

THIS ISN'T THE PLUGIN FAULT, AS IT ALWAYS HAPPENED WHENEVER YOU FLYING YOUR SHIP DOCK TO THE MAGNUS AND OVERLORD(AN POSSIBLY OTHER UNIT) THEN EXIT SHIP THEN OPEN HANGAR THEN UNDOCK

THIS ERROR ALSO WON'T CRASH THE GAME, IT JUST SCREAM [Error  : Unity Log] NullReferenceException IN THE LOG

[Error  : Unity Log] NullReferenceException
Stack trace:
Pixelfactor.IP.UI.DockedShipItemUI.Refresh () (at <8eb6137703954d1cb8ca8d7645480f38>:0)
Pixelfactor.IP.UI.ScrollList`1[T_Item].RefreshAllItems () (at <8eb6137703954d1cb8ca8d7645480f38>:0)
Pixelfactor.IP.UI.ScrollList`1[T_Item].RefreshVisibleItemsIfRequired () (at <8eb6137703954d1cb8ca8d7645480f38>:0)
Pixelfactor.IP.UI.ScrollList`1+<StartVisibleItemRefreshCoroutine>d__67[T_Item].MoveNext () (at <8eb6137703954d1cb8ca8d7645480f38>:0)
UnityEngine.SetupCoroutine.InvokeMoveNext (System.Collections.IEnumerator enumerator, System.IntPtr returnValueAddress) (at <b4d07dbbaa0446c4a7400ff3f626fbc9>:0)


# Anyway Enjoy
