# AeroFortaMoreHangar Plugin
This plugin will add/set the amount of hangar bay for Magnus and Overlord(and any of their variant)
- Customizable for each ship.
- Allowing to set what MaxShipType that allowed to dock.
  
# Currently Known Issue:
Global multiplier so you don't need to individually adjust everything?

THIS ISN'T THE PLUGIN FAULT, AS IT ALWAYS HAPPENED WHENEVER YOU FLYING YOUR SHIP DOCK TO THE MAGNUS AND OVERLORD(AN POSSIBLY OTHER UNIT) THEN EXIT SHIP THEN OPEN HANGAR THEN UNDOCK

[Error  : Unity Log] NullReferenceException
Stack trace:
Pixelfactor.IP.UI.DockedShipItemUI.Refresh () (at <8eb6137703954d1cb8ca8d7645480f38>:0)
Pixelfactor.IP.UI.ScrollList`1[T_Item].RefreshAllItems () (at <8eb6137703954d1cb8ca8d7645480f38>:0)
Pixelfactor.IP.UI.ScrollList`1[T_Item].RefreshVisibleItemsIfRequired () (at <8eb6137703954d1cb8ca8d7645480f38>:0)
Pixelfactor.IP.UI.ScrollList`1+<StartVisibleItemRefreshCoroutine>d__67[T_Item].MoveNext () (at <8eb6137703954d1cb8ca8d7645480f38>:0)
UnityEngine.SetupCoroutine.InvokeMoveNext (System.Collections.IEnumerator enumerator, System.IntPtr returnValueAddress) (at <b4d07dbbaa0446c4a7400ff3f626fbc9>:0)

[Error  :UnityExplorer] [Unity] NullReferenceException

Anyway Enjoy
