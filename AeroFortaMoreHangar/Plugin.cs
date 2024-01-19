using BepInEx;
using BepInEx.Configuration;
using Pixelfactor.IP.Engine;
using UnityEngine;

namespace AeroFortaMoreHangar
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private ConfigEntry<int> numberOfBayHangarUnitMagnusA;
        private ConfigEntry<bool> setNumberInsteadAddUnitMagnusA;
        private ConfigEntry<ShipHullType> maxHullTypeUnitMagnusA;

        private ConfigEntry<int> numberOfBayHangarUnitMagnus;
        private ConfigEntry<bool> setNumberInsteadAddUnitMagnus;
        private ConfigEntry<ShipHullType> maxHullTypeUnitMagnus;

        private ConfigEntry<int> numberOfBayHangarUnitMagnusX;
        private ConfigEntry<bool> setNumberInsteadAddUnitMagnusX;
        private ConfigEntry<ShipHullType> maxHullTypeUnitMagnusX;

        private ConfigEntry<int> numberOfBayHangarUnitMagnusEQ;
        private ConfigEntry<bool> setNumberInsteadAddUnitMagnusEQ;
        private ConfigEntry<ShipHullType> maxHullTypeUnitMagnusEQ;

        private ConfigEntry<int> numberOfBayHangarUnitMagnusXPirateBlack;
        private ConfigEntry<bool> setNumberInsteadAddUnitMagnusXPirateBlack;
        private ConfigEntry<ShipHullType> maxHullTypeUnitMagnusXPirateBlack;

        private ConfigEntry<int> numberOfBayHangarUnitOverlord;
        private ConfigEntry<bool> setNumberInsteadAddUnitOverlord;
        private ConfigEntry<ShipHullType> maxHullTypeUnitOverlord;

        private ConfigEntry<int> numberOfBayHangarUnitOverlordA;
        private ConfigEntry<bool> setNumberInsteadAddUnitOverlordA;
        private ConfigEntry<ShipHullType> maxHullTypeUnitOverlordA;

        private ConfigEntry<int> numberOfBayHangarUnitOverlordX;
        private ConfigEntry<bool> setNumberInsteadAddUnitOverlordX;
        private ConfigEntry<ShipHullType> maxHullTypeUnitOverlordX;

        private void Awake()
        {
            numberOfBayHangarUnitMagnusA = Config.Bind(
                "BayHangar",
                "UnitMagnusA",
                6,
                "Number of hangar bay for UnitMagnusA."
            );
            maxHullTypeUnitMagnusA = Config.Bind(
                "MaxHullType",
                "UnitMagnusA",
                ShipHullType.Frigate,
                "Max hull type for UnitMagnusA, need SetNumberInsteadAddUnitMagnusA To be true because It won't change the already existing hangar bay"
            );
            setNumberInsteadAddUnitMagnusA = Config.Bind(
                "Settings",
                "SetNumberInsteadAddUnitMagnusA",
                false,
                "If true, set the number of hangar bay instead of adding for UnitMagnusA"
            );

            numberOfBayHangarUnitMagnus = Config.Bind(
                "BayHangar",
                "UnitMagnus",
                6,
                "Number of hangar bay for UnitMagnus."
            );
            maxHullTypeUnitMagnus = Config.Bind(
                "MaxHullType",
                "UnitMagnus",
                ShipHullType.Frigate,
                "Max hull type for UnitMagnus, need SetNumberInsteadAddUnitMagnus To be true because It won't change the already existing hangar bay"
            );
            setNumberInsteadAddUnitMagnus = Config.Bind(
                "Settings",
                "SetNumberInsteadAddUnitMagnus",
                false,
                "If true, set the number of hangar bay instead of adding for UnitMagnus"
            );

            numberOfBayHangarUnitMagnusX = Config.Bind(
                "BayHangar",
                "UnitMagnusX",
                6,
                "Number of hangar bay for UnitMagnusX."
            );
            maxHullTypeUnitMagnusX = Config.Bind(
                "MaxHullType",
                "UnitMagnusX",
                ShipHullType.Frigate,
                "Max hull type for UnitMagnusX, need SetNumberInsteadAddUnitMagnusX To be true because It won't change the already existing hangar bay"
            );
            setNumberInsteadAddUnitMagnusX = Config.Bind(
                "Settings",
                "SetNumberInsteadAddUnitMagnusX",
                false,
                "If true, set the number of hangar bay instead of adding for UnitMagnusX"
            );

            numberOfBayHangarUnitMagnusEQ = Config.Bind(
                "BayHangar",
                "UnitMagnusEQ",
                6,
                "Number of hangar bay for UnitMagnusEQ."
            );
            maxHullTypeUnitMagnusEQ = Config.Bind(
                "MaxHullType",
                "UnitMagnusEQ",
                ShipHullType.Frigate,
                "Max hull type for UnitMagnusEQ, need SetNumberInsteadAddUnitMagnusEQ To be true because It won't change the already existing hangar bay"
            );
            setNumberInsteadAddUnitMagnusEQ = Config.Bind(
                "Settings",
                "SetNumberInsteadAddUnitMagnusEQ",
                false,
                "If true, set the number of hangar bay instead of adding for UnitMagnusEQ"
            );

            numberOfBayHangarUnitMagnusXPirateBlack = Config.Bind(
                "BayHangar",
                "UnitMagnusXPirateBlack",
                6,
                "Number of hangar bay for UnitMagnusXPirateBlack."
            );
            maxHullTypeUnitMagnusXPirateBlack = Config.Bind(
                "MaxHullType",
                "UnitMagnusXPirateBlack",
                ShipHullType.Frigate,
                "Max hull type for UnitMagnusXPirateBlack, need SetNumberInsteadAddUnitMagnusXPirateBlack To be true because It won't change the already existing hangar bay"
            );
            setNumberInsteadAddUnitMagnusXPirateBlack = Config.Bind(
                "Settings",
                "SetNumberInsteadAddUnitMagnusXPirateBlack",
                false,
                "If true, set the number of hangar bay instead of adding for UnitMagnusXPirateBlack"
            );

            numberOfBayHangarUnitOverlord = Config.Bind(
                "BayHangar",
                "UnitOverlord",
                3,
                "Number of hangar bay for UnitOverlord."
            );
            maxHullTypeUnitOverlord = Config.Bind(
                "MaxHullType",
                "UnitOverlord",
                ShipHullType.Frigate,
                "Max hull type for UnitOverlord, need SetNumberInsteadAddUnitOverlord To be true because It won't change the already existing hangar bay"
            );
            setNumberInsteadAddUnitOverlord = Config.Bind(
                "Settings",
                "SetNumberInsteadAddUnitOverlord",
                false,
                "If true, set the number of hangar bay instead of adding for UnitOverlord"
            );

            numberOfBayHangarUnitOverlordA = Config.Bind(
                "BayHangar",
                "UnitOverlordA",
                3,
                "Number of hangar bay for UnitOverlordA."
            );
            maxHullTypeUnitOverlordA = Config.Bind(
                "MaxHullType",
                "UnitOverlordA",
                ShipHullType.Frigate,
                "Max hull type for UnitOverlordA, need SetNumberInsteadAddUnitOverlordA To be true because It won't change the already existing hangar bay"
            );
            setNumberInsteadAddUnitOverlordA = Config.Bind(
                "Settings",
                "SetNumberInsteadAddUnitOverlordA",
                false,
                "If true, set the number of hangar bay instead of adding for UnitOverlordA"
            );

            numberOfBayHangarUnitOverlordX = Config.Bind(
                "BayHangar",
                "UnitOverlordX",
                3,
                "Number of hangar bay for UnitOverlordX."
            );
            maxHullTypeUnitOverlordX = Config.Bind(
                "MaxHullType",
                "UnitOverlordX",
                ShipHullType.Frigate,
                "Max hull type for UnitOverlordX, need SetNumberInsteadAddUnitOverlordX To be true because It won't change the already existing hangar bay"
            );
            setNumberInsteadAddUnitOverlordX = Config.Bind(
                "Settings",
                "SetNumberInsteadAddUnitOverlordX",
                false,
                "If true, set the number of hangar bay instead of adding for UnitOverlordX"
            );
            Application.logMessageReceived += OnLogMessageReceived;
        }

        private void OnLogMessageReceived(string logMessage, string stackTrace, LogType logType)
        {
            if (logMessage.Contains("Initialising World: Finished"))
            {
                Application.logMessageReceived -= OnLogMessageReceived;
                FindAndProcessGameObjects();
                Logger.LogInfo($"Plugin More Hangar by AeroForta(Soul) is loaded!");
            }
        }

        private void FindAndProcessGameObjects()
        {
            GameObject[] allGameObjects = Resources.FindObjectsOfTypeAll<GameObject>();
            foreach (var obj in allGameObjects)
            {
                switch (obj.name)
                {
                    case "UnitMagnusA":
                        ProcessUnit(
                            obj.transform.Find("MagnusHangar"),
                            numberOfBayHangarUnitMagnusA.Value,
                            setNumberInsteadAddUnitMagnusA.Value,
                            maxHullTypeUnitMagnusA.Value
                        );
                        break;
                    case "UnitMagnus":
                        ProcessUnit(
                            obj.transform.Find("Docking Bay"),
                            numberOfBayHangarUnitMagnus.Value,
                            setNumberInsteadAddUnitMagnus.Value,
                            maxHullTypeUnitMagnus.Value
                        );
                        break;
                    case "UnitMagnusX":
                        ProcessUnit(
                            obj.transform.Find("MagnusHangar"),
                            numberOfBayHangarUnitMagnusX.Value,
                            setNumberInsteadAddUnitMagnusX.Value,
                            maxHullTypeUnitMagnusX.Value
                        );
                        break;
                    case "UnitMagnusEQ":
                        ProcessUnit(
                            obj.transform.Find("MagnusHangar"),
                            numberOfBayHangarUnitMagnusEQ.Value,
                            setNumberInsteadAddUnitMagnusEQ.Value,
                            maxHullTypeUnitMagnusEQ.Value
                        );
                        break;
                    case "UnitMagnusXPirateBlack":
                        ProcessUnit(
                            obj.transform.Find("MagnusHangar"),
                            numberOfBayHangarUnitMagnusXPirateBlack.Value,
                            setNumberInsteadAddUnitMagnusXPirateBlack.Value,
                            maxHullTypeUnitMagnusXPirateBlack.Value
                        );
                        break;
                    case "UnitOverlord":
                        ProcessUnit(
                            obj.transform.Find("OverlordHangar"),
                            numberOfBayHangarUnitOverlord.Value,
                            setNumberInsteadAddUnitOverlord.Value,
                            maxHullTypeUnitOverlord.Value
                        );
                        break;
                    case "UnitOverlordA":
                        ProcessUnit(
                            obj.transform.Find("Docking Bay"),
                            numberOfBayHangarUnitOverlordA.Value,
                            setNumberInsteadAddUnitOverlordA.Value,
                            maxHullTypeUnitOverlordA.Value
                        );
                        break;
                    case "UnitOverlordX":
                        ProcessUnit(
                            obj.transform.Find("OverlordHangar"),
                            numberOfBayHangarUnitOverlordX.Value,
                            setNumberInsteadAddUnitOverlordX.Value,
                            maxHullTypeUnitOverlordX.Value
                        );
                        break;
                }
            }
        }

        private void ProcessUnit(
            Transform unitHangarTransform,
            int numberOfBayHangar,
            bool setNumberInsteadAdd,
            ShipHullType maxHullType
        )
        {
            if (unitHangarTransform != null)
            {
                GameObject unitHangar = unitHangarTransform.gameObject;
                if (setNumberInsteadAdd)
                {
                    foreach (Transform child in unitHangarTransform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                AddBayHangarToUnitHangar(unitHangar, numberOfBayHangar, maxHullType);
            }
        }

        private void AddBayHangarToUnitHangar(
            GameObject unitHangar,
            int numberOfBayHangar,
            ShipHullType maxHullType
        )
        {
            int startingXValue = 70;
            int incrementXValue = 10;

            for (int i = 0; i < numberOfBayHangar; i++)
            {
                GameObject newHangar = new GameObject(
                    $"Bay_{startingXValue + i * incrementXValue}_Frigate"
                );
                Pixelfactor.IP.Engine.UnitHangarBay unitHangarBay =
                    newHangar.AddComponent<Pixelfactor.IP.Engine.UnitHangarBay>();
                unitHangarBay.BayId = startingXValue + i * incrementXValue;
                unitHangarBay.MaxHullType = maxHullType;
                newHangar.transform.SetParent(unitHangar.transform);
                newHangar.transform.localPosition = Vector3.one;
                newHangar.transform.localRotation = Quaternion.identity;
                newHangar.transform.localScale = Vector3.one;
            }
        }
    }
}
